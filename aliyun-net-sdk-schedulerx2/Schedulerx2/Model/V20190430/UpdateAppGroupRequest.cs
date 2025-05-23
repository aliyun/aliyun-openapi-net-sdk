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
using Aliyun.Acs.schedulerx2.Transform;
using Aliyun.Acs.schedulerx2.Transform.V20190430;

namespace Aliyun.Acs.schedulerx2.Model.V20190430
{
    public class UpdateAppGroupRequest : RpcAcsRequest<UpdateAppGroupResponse>
    {
        public UpdateAppGroupRequest()
            : base("schedulerx2", "2019-04-30", "UpdateAppGroup", "schedulerx2", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.schedulerx2.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.schedulerx2.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string description;

		private string monitorContactsJson;

		private string groupId;

		private int? appVersion;

		private string monitorConfigJson;

		private string _namespace;

		private int? maxConcurrency;

		public string Description
		{
			get
			{
				return description;
			}
			set	
			{
				description = value;
				DictionaryUtil.Add(QueryParameters, "Description", value);
			}
		}

		public string MonitorContactsJson
		{
			get
			{
				return monitorContactsJson;
			}
			set	
			{
				monitorContactsJson = value;
				DictionaryUtil.Add(QueryParameters, "MonitorContactsJson", value);
			}
		}

		public string GroupId
		{
			get
			{
				return groupId;
			}
			set	
			{
				groupId = value;
				DictionaryUtil.Add(QueryParameters, "GroupId", value);
			}
		}

		public int? AppVersion
		{
			get
			{
				return appVersion;
			}
			set	
			{
				appVersion = value;
				DictionaryUtil.Add(QueryParameters, "AppVersion", value.ToString());
			}
		}

		public string MonitorConfigJson
		{
			get
			{
				return monitorConfigJson;
			}
			set	
			{
				monitorConfigJson = value;
				DictionaryUtil.Add(QueryParameters, "MonitorConfigJson", value);
			}
		}

		public string _Namespace
		{
			get
			{
				return _namespace;
			}
			set	
			{
				_namespace = value;
				DictionaryUtil.Add(QueryParameters, "Namespace", value);
			}
		}

		public int? MaxConcurrency
		{
			get
			{
				return maxConcurrency;
			}
			set	
			{
				maxConcurrency = value;
				DictionaryUtil.Add(QueryParameters, "MaxConcurrency", value.ToString());
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override UpdateAppGroupResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return UpdateAppGroupResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
