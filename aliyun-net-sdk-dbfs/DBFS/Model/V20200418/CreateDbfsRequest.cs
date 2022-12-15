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
using Aliyun.Acs.DBFS.Transform;
using Aliyun.Acs.DBFS.Transform.V20200418;

namespace Aliyun.Acs.DBFS.Model.V20200418
{
    public class CreateDbfsRequest : RpcAcsRequest<CreateDbfsResponse>
    {
        public CreateDbfsRequest()
            : base("DBFS", "2020-04-18", "CreateDbfs", "dbfs", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.DBFS.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.DBFS.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private int? sizeG;

		private string snapshotId;

		private string clientToken;

		private string usedScene;

		private string fsName;

		private int? raidStripeUnitNumber;

		private bool? encryption;

		private string instanceType;

		private string advancedFeatures;

		private string performanceLevel;

		private bool? enableRaid;

		private bool? deleteSnapshot;

		private string zoneId;

		private string category;

		private string kMSKeyId;

		[JsonProperty(PropertyName = "SizeG")]
		public int? SizeG
		{
			get
			{
				return sizeG;
			}
			set	
			{
				sizeG = value;
				DictionaryUtil.Add(QueryParameters, "SizeG", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "SnapshotId")]
		public string SnapshotId
		{
			get
			{
				return snapshotId;
			}
			set	
			{
				snapshotId = value;
				DictionaryUtil.Add(QueryParameters, "SnapshotId", value);
			}
		}

		[JsonProperty(PropertyName = "ClientToken")]
		public string ClientToken
		{
			get
			{
				return clientToken;
			}
			set	
			{
				clientToken = value;
				DictionaryUtil.Add(QueryParameters, "ClientToken", value);
			}
		}

		[JsonProperty(PropertyName = "UsedScene")]
		public string UsedScene
		{
			get
			{
				return usedScene;
			}
			set	
			{
				usedScene = value;
				DictionaryUtil.Add(QueryParameters, "UsedScene", value);
			}
		}

		[JsonProperty(PropertyName = "FsName")]
		public string FsName
		{
			get
			{
				return fsName;
			}
			set	
			{
				fsName = value;
				DictionaryUtil.Add(QueryParameters, "FsName", value);
			}
		}

		[JsonProperty(PropertyName = "RaidStripeUnitNumber")]
		public int? RaidStripeUnitNumber
		{
			get
			{
				return raidStripeUnitNumber;
			}
			set	
			{
				raidStripeUnitNumber = value;
				DictionaryUtil.Add(QueryParameters, "RaidStripeUnitNumber", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "Encryption")]
		public bool? Encryption
		{
			get
			{
				return encryption;
			}
			set	
			{
				encryption = value;
				DictionaryUtil.Add(QueryParameters, "Encryption", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "InstanceType")]
		public string InstanceType
		{
			get
			{
				return instanceType;
			}
			set	
			{
				instanceType = value;
				DictionaryUtil.Add(QueryParameters, "InstanceType", value);
			}
		}

		[JsonProperty(PropertyName = "AdvancedFeatures")]
		public string AdvancedFeatures
		{
			get
			{
				return advancedFeatures;
			}
			set	
			{
				advancedFeatures = value;
				DictionaryUtil.Add(QueryParameters, "AdvancedFeatures", value);
			}
		}

		[JsonProperty(PropertyName = "PerformanceLevel")]
		public string PerformanceLevel
		{
			get
			{
				return performanceLevel;
			}
			set	
			{
				performanceLevel = value;
				DictionaryUtil.Add(QueryParameters, "PerformanceLevel", value);
			}
		}

		[JsonProperty(PropertyName = "EnableRaid")]
		public bool? EnableRaid
		{
			get
			{
				return enableRaid;
			}
			set	
			{
				enableRaid = value;
				DictionaryUtil.Add(QueryParameters, "EnableRaid", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "DeleteSnapshot")]
		public bool? DeleteSnapshot
		{
			get
			{
				return deleteSnapshot;
			}
			set	
			{
				deleteSnapshot = value;
				DictionaryUtil.Add(QueryParameters, "DeleteSnapshot", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "ZoneId")]
		public string ZoneId
		{
			get
			{
				return zoneId;
			}
			set	
			{
				zoneId = value;
				DictionaryUtil.Add(QueryParameters, "ZoneId", value);
			}
		}

		[JsonProperty(PropertyName = "Category")]
		public string Category
		{
			get
			{
				return category;
			}
			set	
			{
				category = value;
				DictionaryUtil.Add(QueryParameters, "Category", value);
			}
		}

		[JsonProperty(PropertyName = "KMSKeyId")]
		public string KMSKeyId
		{
			get
			{
				return kMSKeyId;
			}
			set	
			{
				kMSKeyId = value;
				DictionaryUtil.Add(QueryParameters, "KMSKeyId", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override CreateDbfsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateDbfsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
