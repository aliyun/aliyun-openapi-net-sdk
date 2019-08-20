/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using System.Collections.Generic;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.AppMallsService;
using Aliyun.Acs.AppMallsService.Transform;
using Aliyun.Acs.AppMallsService.Transform.V20180224;

namespace Aliyun.Acs.AppMallsService.Model.V20180224
{
    public class TaobaoFilmGetSeatsRequest : RpcAcsRequest<TaobaoFilmGetSeatsResponse>
    {
        public TaobaoFilmGetSeatsRequest()
            : base("AppMallsService", "2018-02-24", "TaobaoFilmGetSeats")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
        }

		private long? scheduleId;

		private string paramsJson;

		public long? ScheduleId
		{
			get
			{
				return scheduleId;
			}
			set	
			{
				scheduleId = value;
				DictionaryUtil.Add(QueryParameters, "ScheduleId", value.ToString());
			}
		}

		public string ParamsJson
		{
			get
			{
				return paramsJson;
			}
			set	
			{
				paramsJson = value;
				DictionaryUtil.Add(QueryParameters, "ParamsJson", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override TaobaoFilmGetSeatsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return TaobaoFilmGetSeatsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
