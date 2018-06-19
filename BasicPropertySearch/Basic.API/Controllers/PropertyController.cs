using AutoMapper;
using Basic.API.BLL.DB.Entity;
using Basic.API.BLL.DB.Repositories.Interfaces;
using Basic.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Basic.API.Controllers
{

    /// <summary>
    /// Property search API
    /// </summary>
    [RoutePrefix("v1/Property")]
    public class PropertyController : ApiController
    {
        private IPropertyRepository _PropertyRepository { get; set; }
        private static readonly log4net.ILog log =
                log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="PropertyRepository"></param>
        public PropertyController(IPropertyRepository PropertyRepository)
        {
            _PropertyRepository = PropertyRepository;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>#
        [Route("{id}")]
        public IHttpActionResult Get(int id)
        {
            try
            {
                var result = _PropertyRepository.Get(id, null);

                if (result == null)
                {
                    return NotFound();
                }

                return Ok(Mapper.Map<Property, PropertyModel>(result));
            }
            catch (Exception ex)
            {
                log.Error(ex);
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IHttpActionResult Post([FromBody]SearchParametersModel searchParametersModel)
        {
            try
            {
                var result = _PropertyRepository.Get(Mapper.Map<SearchParametersModel, SearchParameters>(searchParametersModel), null);

                return Ok(Mapper.Map<IEnumerable<Property>, IEnumerable<PropertyModel>>(result));
            }
            catch (Exception ex)
            {
                log.Error(ex);
                return BadRequest(ex.Message);
            }
        }
    }
}
