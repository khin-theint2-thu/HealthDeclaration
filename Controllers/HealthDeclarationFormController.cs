using CovidHealthDeclarationForm.Data;
using CovidHealthDeclarationForm.Enums;
using CovidHealthDeclarationForm.Models;
using CovidHealthDeclarationForm.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace CovidHealthDeclarationForm.Controllers
{
    public class HealthDeclarationFormController : BaseController
    {
        private readonly ApplicationDBContext _db;

        private readonly IAcivityLogger _logger;
        
        public HealthDeclarationFormController(ApplicationDBContext db,IAcivityLogger logger, IConfiguration configuration): base(configuration)
        {
            _db = db;
            _logger = logger;
        }
        
        public IActionResult Index()
        {
            return View();
        }

        [Route("HealthDeclarationForm/Detail")]
        public IActionResult Detail(string visitorid)
        {
            try
            {
                var obj = _db.HealthDeclarationData.Where(x => !string.IsNullOrEmpty(visitorid) && x.VisitorID == visitorid).FirstOrDefault();

                _logger.writeLog(_db, "record detail", LogLevel.Info.ToString(), "HealthDeclarationController", ActionStatus.Read.ToString());

                CreateAlertMessage("info", "Loaded record!");

                return View("Index", obj);
            }
            catch (Exception ex)
            {
                _logger.writeLog(_db, "error", LogLevel.Error.ToString(), "HealthDeclarationController", ActionStatus.Delete.ToString());

                CreateAlertMessage("error", ex.Message);

                return View();
            }
        }

        public IActionResult ViewList()
        {
            IEnumerable<HealthDeclarationData> objlist = _db.HealthDeclarationData;

            return View(objlist);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(HealthDeclarationData obj)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (string.IsNullOrEmpty(obj.VisitorID))
                    {
                        //save sensordata
                        Task<SensorData> data = SaveSensorData("apiURL");
                        obj.VisitorID = Guid.NewGuid().ToString();
                        obj.SensorDataID = data.Result != null ? data.Result.SensorDataID : string.Empty;
                        obj.CreatedOn = DateTime.Now;
                        obj.ModifiedOn = DateTime.Now;
                        obj.Active = true;
                        _db.HealthDeclarationData.Add(obj);

                        _logger.writeLog(_db, "save record", LogLevel.Info.ToString(), "HealthDeclarationController", ActionStatus.Create.ToString());

                    }
                    else
                    {
                        obj.ModifiedOn = DateTime.Now;
                        _db.Update(obj);

                        _logger.writeLog(_db, "update record", LogLevel.Info.ToString(), "HealthDeclarationController", ActionStatus.Update.ToString());

                    }

                    _db.SaveChanges();

                    CreateAlertMessage("success", "Submitted record successfully.");

                    ModelState.Clear();

                }
                else
                {
                    _logger.writeLog(_db, "model state not valid.", LogLevel.Warning.ToString(), "HealthDeclarationController", ActionStatus.Create.ToString());

                    CreateAlertMessage("warning", "Please fill all required data!");

                }

                return View();

            }
            catch (Exception ex)
            {
                _logger.writeLog(_db, "error", LogLevel.Error.ToString(), "HealthDeclarationController", ActionStatus.Create.ToString());

                CreateAlertMessage("error", ex.Message);

                return View(obj);
            }
        }
        
        public async Task<SensorData> SaveSensorData(string apiUrl)
        {
            try
            {
                SensorData sensorData = new SensorData();

                using (HttpClient httpClient = new HttpClient())
                {
                    HttpResponseMessage response = await httpClient.GetAsync(apiUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        string json = await response.Content.ReadAsStringAsync();
                        json = "{'deviceId':'ibm-8989','deviceType':'computer1.0.0','deviceName':'VN1-099','data':{'temperature':21,'humidity':43,'occupancy':false}}";
                        dynamic jsonObject = JsonConvert.DeserializeObject<dynamic>(json);

                        if (jsonObject != null)
                        {
                            sensorData.SensorDataID = Guid.NewGuid().ToString();
                            sensorData.DeviceID = jsonObject["deviceId"];
                            sensorData.DeviceType = jsonObject["deviceType"];
                            sensorData.DeviceName = jsonObject["deviceName"];

                            sensorData.Humidity = jsonObject["data"]["humidity"];
                            sensorData.Temperature = jsonObject["data"]["temperature"];
                            sensorData.Occupancy = jsonObject["data"]["occupancy"];

                            _db.SensorData.Add(sensorData);
                            _db.SaveChanges();
                        }

                        _logger.writeLog(_db, "save sensor data", LogLevel.Info.ToString(), "HealthDeclarationController", ActionStatus.Create.ToString());

                    }
                    else
                    {
                        _logger.writeLog(_db, "http error", LogLevel.Error.ToString(), "HealthDeclarationController", ActionStatus.Create.ToString());

                        throw new HttpRequestException($"HTTP request failed with status code {response.StatusCode}");
                    }
                }
                return sensorData;
            }
            catch (Exception ex)
            {
                _logger.writeLog(_db, "error", LogLevel.Error.ToString(), "HealthDeclarationController", ActionStatus.Create.ToString());

                CreateAlertMessage("error", ex.Message);

                return null;
            }
        }
        
        private void CreateAlertMessage(string alertType,string alertMessage)
        {
            ViewBag.AlertType = alertType;
            ViewBag.AlertMessage = alertMessage;
        }

    }
}
