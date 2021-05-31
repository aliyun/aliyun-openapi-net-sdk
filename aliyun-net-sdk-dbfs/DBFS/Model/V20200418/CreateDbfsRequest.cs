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
using Aliyun.Acs.DBFS;
using Aliyun.Acs.DBFS.Transform;
using Aliyun.Acs.DBFS.Transform.V20200418;

namespace Aliyun.Acs.DBFS.Model.V20200418
{
    public class CreateDbfsRequest : RpcAcsRequest<CreateDbfsResponse>
    {
        public CreateDbfsRequest()
            : base("DBFS", "2020-04-18", "CreateDbfs")
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

		private string performanceLevel;

		private bool? enableRaid;

		private bool? deleteSnapshot;

		private string zoneId;

		private string category;

		private string kMSKeyId;

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
