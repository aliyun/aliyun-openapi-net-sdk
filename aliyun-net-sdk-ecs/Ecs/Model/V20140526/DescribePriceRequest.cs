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
using Aliyun.Acs.Ecs.Transform;
using Aliyun.Acs.Ecs.Transform.V20140526;

namespace Aliyun.Acs.Ecs.Model.V20140526
{
    public class DescribePriceRequest : RpcAcsRequest<DescribePriceResponse>
    {
        public DescribePriceRequest()
            : base("Ecs", "2014-05-26", "DescribePrice", "ecs", "openAPI")
        {
        }

		private string dataDisk3PerformanceLevel;

		private int? dataDisk3Size;

		private long? resourceOwnerId;

		private string imageId;

		private string dataDisk3Category;

		private string ioOptimized;

		private int? internetMaxBandwidthOut;

		private string systemDiskCategory;

		private string systemDiskPerformanceLevel;

		private string dataDisk4Category;

		private string dataDisk4PerformanceLevel;

		private int? dataDisk4Size;

		private string priceUnit;

		private string instanceType;

		private string dataDisk2Category;

		private int? dataDisk1Size;

		private int? period;

		private int? amount;

		private string resourceOwnerAccount;

		private string ownerAccount;

		private int? dataDisk2Size;

		private string dataDisk1PerformanceLevel;

		private long? ownerId;

		private string resourceType;

		private string dataDisk1Category;

		private string dataDisk2PerformanceLevel;

		private int? systemDiskSize;

		private string internetChargeType;

		private string instanceNetworkType;

		public string DataDisk3PerformanceLevel
		{
			get
			{
				return dataDisk3PerformanceLevel;
			}
			set	
			{
				dataDisk3PerformanceLevel = value;
				DictionaryUtil.Add(QueryParameters, "DataDisk.3.PerformanceLevel", value);
			}
		}

		public int? DataDisk3Size
		{
			get
			{
				return dataDisk3Size;
			}
			set	
			{
				dataDisk3Size = value;
				DictionaryUtil.Add(QueryParameters, "DataDisk.3.Size", value.ToString());
			}
		}

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

		public string ImageId
		{
			get
			{
				return imageId;
			}
			set	
			{
				imageId = value;
				DictionaryUtil.Add(QueryParameters, "ImageId", value);
			}
		}

		public string DataDisk3Category
		{
			get
			{
				return dataDisk3Category;
			}
			set	
			{
				dataDisk3Category = value;
				DictionaryUtil.Add(QueryParameters, "DataDisk.3.Category", value);
			}
		}

		public string IoOptimized
		{
			get
			{
				return ioOptimized;
			}
			set	
			{
				ioOptimized = value;
				DictionaryUtil.Add(QueryParameters, "IoOptimized", value);
			}
		}

		public int? InternetMaxBandwidthOut
		{
			get
			{
				return internetMaxBandwidthOut;
			}
			set	
			{
				internetMaxBandwidthOut = value;
				DictionaryUtil.Add(QueryParameters, "InternetMaxBandwidthOut", value.ToString());
			}
		}

		public string SystemDiskCategory
		{
			get
			{
				return systemDiskCategory;
			}
			set	
			{
				systemDiskCategory = value;
				DictionaryUtil.Add(QueryParameters, "SystemDisk.Category", value);
			}
		}

		public string SystemDiskPerformanceLevel
		{
			get
			{
				return systemDiskPerformanceLevel;
			}
			set	
			{
				systemDiskPerformanceLevel = value;
				DictionaryUtil.Add(QueryParameters, "SystemDisk.PerformanceLevel", value);
			}
		}

		public string DataDisk4Category
		{
			get
			{
				return dataDisk4Category;
			}
			set	
			{
				dataDisk4Category = value;
				DictionaryUtil.Add(QueryParameters, "DataDisk.4.Category", value);
			}
		}

		public string DataDisk4PerformanceLevel
		{
			get
			{
				return dataDisk4PerformanceLevel;
			}
			set	
			{
				dataDisk4PerformanceLevel = value;
				DictionaryUtil.Add(QueryParameters, "DataDisk.4.PerformanceLevel", value);
			}
		}

		public int? DataDisk4Size
		{
			get
			{
				return dataDisk4Size;
			}
			set	
			{
				dataDisk4Size = value;
				DictionaryUtil.Add(QueryParameters, "DataDisk.4.Size", value.ToString());
			}
		}

		public string PriceUnit
		{
			get
			{
				return priceUnit;
			}
			set	
			{
				priceUnit = value;
				DictionaryUtil.Add(QueryParameters, "PriceUnit", value);
			}
		}

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

		public string DataDisk2Category
		{
			get
			{
				return dataDisk2Category;
			}
			set	
			{
				dataDisk2Category = value;
				DictionaryUtil.Add(QueryParameters, "DataDisk.2.Category", value);
			}
		}

		public int? DataDisk1Size
		{
			get
			{
				return dataDisk1Size;
			}
			set	
			{
				dataDisk1Size = value;
				DictionaryUtil.Add(QueryParameters, "DataDisk.1.Size", value.ToString());
			}
		}

		public int? Period
		{
			get
			{
				return period;
			}
			set	
			{
				period = value;
				DictionaryUtil.Add(QueryParameters, "Period", value.ToString());
			}
		}

		public int? Amount
		{
			get
			{
				return amount;
			}
			set	
			{
				amount = value;
				DictionaryUtil.Add(QueryParameters, "Amount", value.ToString());
			}
		}

		public string ResourceOwnerAccount
		{
			get
			{
				return resourceOwnerAccount;
			}
			set	
			{
				resourceOwnerAccount = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerAccount", value);
			}
		}

		public string OwnerAccount
		{
			get
			{
				return ownerAccount;
			}
			set	
			{
				ownerAccount = value;
				DictionaryUtil.Add(QueryParameters, "OwnerAccount", value);
			}
		}

		public int? DataDisk2Size
		{
			get
			{
				return dataDisk2Size;
			}
			set	
			{
				dataDisk2Size = value;
				DictionaryUtil.Add(QueryParameters, "DataDisk.2.Size", value.ToString());
			}
		}

		public string DataDisk1PerformanceLevel
		{
			get
			{
				return dataDisk1PerformanceLevel;
			}
			set	
			{
				dataDisk1PerformanceLevel = value;
				DictionaryUtil.Add(QueryParameters, "DataDisk.1.PerformanceLevel", value);
			}
		}

		public long? OwnerId
		{
			get
			{
				return ownerId;
			}
			set	
			{
				ownerId = value;
				DictionaryUtil.Add(QueryParameters, "OwnerId", value.ToString());
			}
		}

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

		public string DataDisk1Category
		{
			get
			{
				return dataDisk1Category;
			}
			set	
			{
				dataDisk1Category = value;
				DictionaryUtil.Add(QueryParameters, "DataDisk.1.Category", value);
			}
		}

		public string DataDisk2PerformanceLevel
		{
			get
			{
				return dataDisk2PerformanceLevel;
			}
			set	
			{
				dataDisk2PerformanceLevel = value;
				DictionaryUtil.Add(QueryParameters, "DataDisk.2.PerformanceLevel", value);
			}
		}

		public int? SystemDiskSize
		{
			get
			{
				return systemDiskSize;
			}
			set	
			{
				systemDiskSize = value;
				DictionaryUtil.Add(QueryParameters, "SystemDisk.Size", value.ToString());
			}
		}

		public string InternetChargeType
		{
			get
			{
				return internetChargeType;
			}
			set	
			{
				internetChargeType = value;
				DictionaryUtil.Add(QueryParameters, "InternetChargeType", value);
			}
		}

		public string InstanceNetworkType
		{
			get
			{
				return instanceNetworkType;
			}
			set	
			{
				instanceNetworkType = value;
				DictionaryUtil.Add(QueryParameters, "InstanceNetworkType", value);
			}
		}

        public override DescribePriceResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribePriceResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
