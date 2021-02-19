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
using Aliyun.Acs.cloudesl.Transform;
using Aliyun.Acs.cloudesl.Transform.V20200201;

namespace Aliyun.Acs.cloudesl.Model.V20200201
{
    public class DescribeAlarmsRequest : RpcAcsRequest<DescribeAlarmsResponse>
    {
        public DescribeAlarmsRequest()
            : base("cloudesl", "2020-02-01", "DescribeAlarms", "cloudesl", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.cloudesl.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.cloudesl.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string extraParams;

		private string storeId;

		private int? pageNumber;

		private int? pageSize;

		private string alarmType;

		private string alarmStatus;

		private string errorType;

		private string alarmId;

		private string deviceMac;

		public string ExtraParams
		{
			get
			{
				return extraParams;
			}
			set	
			{
				extraParams = value;
				DictionaryUtil.Add(BodyParameters, "ExtraParams", value);
			}
		}

		public string StoreId
		{
			get
			{
				return storeId;
			}
			set	
			{
				storeId = value;
				DictionaryUtil.Add(BodyParameters, "StoreId", value);
			}
		}

		public int? PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
				DictionaryUtil.Add(BodyParameters, "PageNumber", value.ToString());
			}
		}

		public int? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
				DictionaryUtil.Add(BodyParameters, "PageSize", value.ToString());
			}
		}

		public string AlarmType
		{
			get
			{
				return alarmType;
			}
			set	
			{
				alarmType = value;
				DictionaryUtil.Add(BodyParameters, "AlarmType", value);
			}
		}

		public string AlarmStatus
		{
			get
			{
				return alarmStatus;
			}
			set	
			{
				alarmStatus = value;
				DictionaryUtil.Add(BodyParameters, "AlarmStatus", value);
			}
		}

		public string ErrorType
		{
			get
			{
				return errorType;
			}
			set	
			{
				errorType = value;
				DictionaryUtil.Add(BodyParameters, "ErrorType", value);
			}
		}

		public string AlarmId
		{
			get
			{
				return alarmId;
			}
			set	
			{
				alarmId = value;
				DictionaryUtil.Add(BodyParameters, "AlarmId", value);
			}
		}

		public string DeviceMac
		{
			get
			{
				return deviceMac;
			}
			set	
			{
				deviceMac = value;
				DictionaryUtil.Add(BodyParameters, "DeviceMac", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override DescribeAlarmsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribeAlarmsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
