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
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.CloudAPI.Transform;
using Aliyun.Acs.CloudAPI.Transform.V20160714;
using System.Collections.Generic;

namespace Aliyun.Acs.CloudAPI.Model.V20160714
{
    public class CreateTrafficControlRequest : RpcAcsRequest<CreateTrafficControlResponse>
    {
        public CreateTrafficControlRequest()
            : base("CloudAPI", "2016-07-14", "CreateTrafficControl")
        {
        }

		private string trafficControlName;

		private string trafficControlUnit;

		private int? apiDefault;

		private int? userDefault;

		private int? appDefault;

		private string description;

		public string TrafficControlName
		{
			get
			{
				return trafficControlName;
			}
			set	
			{
				trafficControlName = value;
				DictionaryUtil.Add(QueryParameters, "TrafficControlName", value);
			}
		}

		public string TrafficControlUnit
		{
			get
			{
				return trafficControlUnit;
			}
			set	
			{
				trafficControlUnit = value;
				DictionaryUtil.Add(QueryParameters, "TrafficControlUnit", value);
			}
		}

		public int? ApiDefault
		{
			get
			{
				return apiDefault;
			}
			set	
			{
				apiDefault = value;
				DictionaryUtil.Add(QueryParameters, "ApiDefault", value.ToString());
			}
		}

		public int? UserDefault
		{
			get
			{
				return userDefault;
			}
			set	
			{
				userDefault = value;
				DictionaryUtil.Add(QueryParameters, "UserDefault", value.ToString());
			}
		}

		public int? AppDefault
		{
			get
			{
				return appDefault;
			}
			set	
			{
				appDefault = value;
				DictionaryUtil.Add(QueryParameters, "AppDefault", value.ToString());
			}
		}

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

        public override CreateTrafficControlResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return CreateTrafficControlResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}