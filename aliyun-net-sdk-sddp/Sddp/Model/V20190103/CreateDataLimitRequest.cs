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
using Aliyun.Acs.Sddp;
using Aliyun.Acs.Sddp.Transform;
using Aliyun.Acs.Sddp.Transform.V20190103;

namespace Aliyun.Acs.Sddp.Model.V20190103
{
    public class CreateDataLimitRequest : RpcAcsRequest<CreateDataLimitResponse>
    {
        public CreateDataLimitRequest()
            : base("Sddp", "2019-01-03", "CreateDataLimit")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Sddp.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Sddp.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private int? ocrStatus;

		private string parentId;

		private string password;

		private string lang;

		private string serviceRegionId;

		private string engineType;

		private int? auditStatus;

		private int? autoScan;

		private int? logStoreDay;

		private int? resourceType;

		private int? port;

		private int? eventStatus;

		private string userName;

		public int? OcrStatus
		{
			get
			{
				return ocrStatus;
			}
			set	
			{
				ocrStatus = value;
				DictionaryUtil.Add(QueryParameters, "OcrStatus", value.ToString());
			}
		}

		public string ParentId
		{
			get
			{
				return parentId;
			}
			set	
			{
				parentId = value;
				DictionaryUtil.Add(QueryParameters, "ParentId", value);
			}
		}

		public string Password
		{
			get
			{
				return password;
			}
			set	
			{
				password = value;
				DictionaryUtil.Add(QueryParameters, "Password", value);
			}
		}

		public string Lang
		{
			get
			{
				return lang;
			}
			set	
			{
				lang = value;
				DictionaryUtil.Add(QueryParameters, "Lang", value);
			}
		}

		public string ServiceRegionId
		{
			get
			{
				return serviceRegionId;
			}
			set	
			{
				serviceRegionId = value;
				DictionaryUtil.Add(QueryParameters, "ServiceRegionId", value);
			}
		}

		public string EngineType
		{
			get
			{
				return engineType;
			}
			set	
			{
				engineType = value;
				DictionaryUtil.Add(QueryParameters, "EngineType", value);
			}
		}

		public int? AuditStatus
		{
			get
			{
				return auditStatus;
			}
			set	
			{
				auditStatus = value;
				DictionaryUtil.Add(QueryParameters, "AuditStatus", value.ToString());
			}
		}

		public int? AutoScan
		{
			get
			{
				return autoScan;
			}
			set	
			{
				autoScan = value;
				DictionaryUtil.Add(QueryParameters, "AutoScan", value.ToString());
			}
		}

		public int? LogStoreDay
		{
			get
			{
				return logStoreDay;
			}
			set	
			{
				logStoreDay = value;
				DictionaryUtil.Add(QueryParameters, "LogStoreDay", value.ToString());
			}
		}

		public int? ResourceType
		{
			get
			{
				return resourceType;
			}
			set	
			{
				resourceType = value;
				DictionaryUtil.Add(QueryParameters, "ResourceType", value.ToString());
			}
		}

		public int? Port
		{
			get
			{
				return port;
			}
			set	
			{
				port = value;
				DictionaryUtil.Add(QueryParameters, "Port", value.ToString());
			}
		}

		public int? EventStatus
		{
			get
			{
				return eventStatus;
			}
			set	
			{
				eventStatus = value;
				DictionaryUtil.Add(QueryParameters, "EventStatus", value.ToString());
			}
		}

		public string UserName
		{
			get
			{
				return userName;
			}
			set	
			{
				userName = value;
				DictionaryUtil.Add(QueryParameters, "UserName", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override CreateDataLimitResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateDataLimitResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
