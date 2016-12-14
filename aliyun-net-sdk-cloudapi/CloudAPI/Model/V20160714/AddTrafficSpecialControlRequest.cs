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
    public class AddTrafficSpecialControlRequest : RpcAcsRequest<AddTrafficSpecialControlResponse>
    {
        public AddTrafficSpecialControlRequest()
            : base("CloudAPI", "2016-07-14", "AddTrafficSpecialControl")
        {
        }

		private string trafficControlId;

		private string specialType;

		private string specialKey;

		private int? trafficValue;

		public string TrafficControlId
		{
			get
			{
				return trafficControlId;
			}
			set	
			{
				trafficControlId = value;
				DictionaryUtil.Add(QueryParameters, "TrafficControlId", value);
			}
		}

		public string SpecialType
		{
			get
			{
				return specialType;
			}
			set	
			{
				specialType = value;
				DictionaryUtil.Add(QueryParameters, "SpecialType", value);
			}
		}

		public string SpecialKey
		{
			get
			{
				return specialKey;
			}
			set	
			{
				specialKey = value;
				DictionaryUtil.Add(QueryParameters, "SpecialKey", value);
			}
		}

		public int? TrafficValue
		{
			get
			{
				return trafficValue;
			}
			set	
			{
				trafficValue = value;
				DictionaryUtil.Add(QueryParameters, "TrafficValue", value.ToString());
			}
		}

        public override AddTrafficSpecialControlResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return AddTrafficSpecialControlResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}