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
using Newtonsoft.Json;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Edas.Transform;
using Aliyun.Acs.Edas.Transform.V20170801;

namespace Aliyun.Acs.Edas.Model.V20170801
{
    public class UpdateSwimmingLaneRequest : RoaAcsRequest<UpdateSwimmingLaneResponse>
    {
        public UpdateSwimmingLaneRequest()
            : base("Edas", "2017-08-01", "UpdateSwimmingLane", "Edas", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Edas.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Edas.Endpoint.endpointRegionalType, null);
            }
			UriPattern = "/pop/v5/trafficmgnt/swimming_lanes";
			Method = MethodType.PUT;
        }

		private string appInfos;

		private long? laneId;

		private string entryRules;

		private bool? enableRules;

		private string name;

		public string AppInfos
		{
			get
			{
				return appInfos;
			}
			set	
			{
				appInfos = value;
				DictionaryUtil.Add(QueryParameters, "AppInfos", value);
			}
		}

		public long? LaneId
		{
			get
			{
				return laneId;
			}
			set	
			{
				laneId = value;
				DictionaryUtil.Add(QueryParameters, "LaneId", value.ToString());
			}
		}

		public string EntryRules
		{
			get
			{
				return entryRules;
			}
			set	
			{
				entryRules = value;
				DictionaryUtil.Add(QueryParameters, "EntryRules", value);
			}
		}

		public bool? EnableRules
		{
			get
			{
				return enableRules;
			}
			set	
			{
				enableRules = value;
				DictionaryUtil.Add(QueryParameters, "EnableRules", value.ToString());
			}
		}

		public string Name
		{
			get
			{
				return name;
			}
			set	
			{
				name = value;
				DictionaryUtil.Add(QueryParameters, "Name", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override UpdateSwimmingLaneResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return UpdateSwimmingLaneResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
