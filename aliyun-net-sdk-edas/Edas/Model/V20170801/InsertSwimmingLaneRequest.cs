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
using Aliyun.Acs.Edas.Transform;
using Aliyun.Acs.Edas.Transform.V20170801;

namespace Aliyun.Acs.Edas.Model.V20170801
{
    public class InsertSwimmingLaneRequest : RoaAcsRequest<InsertSwimmingLaneResponse>
    {
        public InsertSwimmingLaneRequest()
            : base("Edas", "2017-08-01", "InsertSwimmingLane", "Edas", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Edas.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Edas.Endpoint.endpointRegionalType, null);
            }
			UriPattern = "/pop/v5/trafficmgnt/swimming_lanes";
			Method = MethodType.POST;
        }

		private string appInfos;

		private string entryRules;

		private string logicalRegionId;

		private bool? enableRules;

		private long? groupId;

		private string name;

		private string tag;

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

		public string LogicalRegionId
		{
			get
			{
				return logicalRegionId;
			}
			set	
			{
				logicalRegionId = value;
				DictionaryUtil.Add(QueryParameters, "LogicalRegionId", value);
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

		public long? GroupId
		{
			get
			{
				return groupId;
			}
			set	
			{
				groupId = value;
				DictionaryUtil.Add(QueryParameters, "GroupId", value.ToString());
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

		public string Tag
		{
			get
			{
				return tag;
			}
			set	
			{
				tag = value;
				DictionaryUtil.Add(QueryParameters, "Tag", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override InsertSwimmingLaneResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return InsertSwimmingLaneResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
