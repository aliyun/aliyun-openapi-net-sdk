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
using Aliyun.Acs.Rds.Transform;
using Aliyun.Acs.Rds.Transform.V20140815;

namespace Aliyun.Acs.Rds.Model.V20140815
{
    public class ModifyCustinsResourceRequest : RpcAcsRequest<ModifyCustinsResourceResponse>
    {
        public ModifyCustinsResourceRequest()
            : base("Rds", "2014-08-15", "ModifyCustinsResource", "rds", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Rds.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Rds.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? resourceOwnerId;

		private string increaseRatio;

		private string restoreOriginalSpecification;

		private string dBInstanceId;

		private string resourceType;

		private string adjustDeadline;

		private int? targetValue;

		[JsonProperty(PropertyName = "ResourceOwnerId")]
		public long? ResourceOwnerId
		{
			get
			{
				return resourceOwnerId;
			}
			set	
			{
				resourceOwnerId = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerId", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "IncreaseRatio")]
		public string IncreaseRatio
		{
			get
			{
				return increaseRatio;
			}
			set	
			{
				increaseRatio = value;
				DictionaryUtil.Add(QueryParameters, "IncreaseRatio", value);
			}
		}

		[JsonProperty(PropertyName = "RestoreOriginalSpecification")]
		public string RestoreOriginalSpecification
		{
			get
			{
				return restoreOriginalSpecification;
			}
			set	
			{
				restoreOriginalSpecification = value;
				DictionaryUtil.Add(QueryParameters, "RestoreOriginalSpecification", value);
			}
		}

		[JsonProperty(PropertyName = "DBInstanceId")]
		public string DBInstanceId
		{
			get
			{
				return dBInstanceId;
			}
			set	
			{
				dBInstanceId = value;
				DictionaryUtil.Add(QueryParameters, "DBInstanceId", value);
			}
		}

		[JsonProperty(PropertyName = "ResourceType")]
		public string ResourceType
		{
			get
			{
				return resourceType;
			}
			set	
			{
				resourceType = value;
				DictionaryUtil.Add(QueryParameters, "ResourceType", value);
			}
		}

		[JsonProperty(PropertyName = "AdjustDeadline")]
		public string AdjustDeadline
		{
			get
			{
				return adjustDeadline;
			}
			set	
			{
				adjustDeadline = value;
				DictionaryUtil.Add(QueryParameters, "AdjustDeadline", value);
			}
		}

		[JsonProperty(PropertyName = "TargetValue")]
		public int? TargetValue
		{
			get
			{
				return targetValue;
			}
			set	
			{
				targetValue = value;
				DictionaryUtil.Add(QueryParameters, "TargetValue", value.ToString());
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ModifyCustinsResourceResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ModifyCustinsResourceResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
