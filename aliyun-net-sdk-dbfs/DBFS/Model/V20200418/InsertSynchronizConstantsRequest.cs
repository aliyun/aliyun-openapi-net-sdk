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
    public class InsertSynchronizConstantsRequest : RpcAcsRequest<InsertSynchronizConstantsResponse>
    {
        public InsertSynchronizConstantsRequest()
            : base("DBFS", "2020-04-18", "InsertSynchronizConstants")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.DBFS.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.DBFS.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string zoneData;

		private string osversionData;

		private string endpointData;

		private int? pageNumber;

		private string masterData;

		private string productCodeData;

		private int? pageSize;

		private string accessData;

		private string regionData;

		public string ZoneData
		{
			get
			{
				return zoneData;
			}
			set	
			{
				zoneData = value;
				DictionaryUtil.Add(QueryParameters, "ZoneData", value);
			}
		}

		public string OsversionData
		{
			get
			{
				return osversionData;
			}
			set	
			{
				osversionData = value;
				DictionaryUtil.Add(QueryParameters, "OsversionData", value);
			}
		}

		public string EndpointData
		{
			get
			{
				return endpointData;
			}
			set	
			{
				endpointData = value;
				DictionaryUtil.Add(QueryParameters, "EndpointData", value);
			}
		}

		public int? PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
				DictionaryUtil.Add(QueryParameters, "PageNumber", value.ToString());
			}
		}

		public string MasterData
		{
			get
			{
				return masterData;
			}
			set	
			{
				masterData = value;
				DictionaryUtil.Add(QueryParameters, "MasterData", value);
			}
		}

		public string ProductCodeData
		{
			get
			{
				return productCodeData;
			}
			set	
			{
				productCodeData = value;
				DictionaryUtil.Add(QueryParameters, "ProductCodeData", value);
			}
		}

		public int? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
				DictionaryUtil.Add(QueryParameters, "PageSize", value.ToString());
			}
		}

		public string AccessData
		{
			get
			{
				return accessData;
			}
			set	
			{
				accessData = value;
				DictionaryUtil.Add(QueryParameters, "AccessData", value);
			}
		}

		public string RegionData
		{
			get
			{
				return regionData;
			}
			set	
			{
				regionData = value;
				DictionaryUtil.Add(QueryParameters, "RegionData", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override InsertSynchronizConstantsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return InsertSynchronizConstantsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
