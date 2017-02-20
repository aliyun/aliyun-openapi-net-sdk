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
using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.CloudAPI.Transform.V20160714;

namespace Aliyun.Acs.CloudAPI.Model.V20160714
{
    public class ModifyTrafficControlRequest : RpcAcsRequest<ModifyTrafficControlResponse>
    {
        public ModifyTrafficControlRequest()
            : base("CloudAPI", "2016-07-14", "ModifyTrafficControl")
        {
        }

		private string _trafficControlId;

		private string _trafficControlName;

		private string _trafficControlUnit;

		private int? _apiDefault;

		private int? _userDefault;

		private int? _appDefault;

		private string _description;

		public string TrafficControlId
		{
			get
			{
				return _trafficControlId;
			}
			set	
			{
				_trafficControlId = value;
				DictionaryUtil.Add(QueryParameters, "TrafficControlId", value);
			}
		}

		public string TrafficControlName
		{
			get
			{
				return _trafficControlName;
			}
			set	
			{
				_trafficControlName = value;
				DictionaryUtil.Add(QueryParameters, "TrafficControlName", value);
			}
		}

		public string TrafficControlUnit
		{
			get
			{
				return _trafficControlUnit;
			}
			set	
			{
				_trafficControlUnit = value;
				DictionaryUtil.Add(QueryParameters, "TrafficControlUnit", value);
			}
		}

		public int? ApiDefault
		{
			get
			{
				return _apiDefault;
			}
			set	
			{
				_apiDefault = value;
				DictionaryUtil.Add(QueryParameters, "ApiDefault", value.ToString());
			}
		}

		public int? UserDefault
		{
			get
			{
				return _userDefault;
			}
			set	
			{
				_userDefault = value;
				DictionaryUtil.Add(QueryParameters, "UserDefault", value.ToString());
			}
		}

		public int? AppDefault
		{
			get
			{
				return _appDefault;
			}
			set	
			{
				_appDefault = value;
				DictionaryUtil.Add(QueryParameters, "AppDefault", value.ToString());
			}
		}

		public string Description
		{
			get
			{
				return _description;
			}
			set	
			{
				_description = value;
				DictionaryUtil.Add(QueryParameters, "Description", value);
			}
		}

        public override ModifyTrafficControlResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return ModifyTrafficControlResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}