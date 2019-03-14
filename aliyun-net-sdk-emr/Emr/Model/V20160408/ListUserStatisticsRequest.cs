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
using Aliyun.Acs.Emr.Transform;
using Aliyun.Acs.Emr.Transform.V20160408;

namespace Aliyun.Acs.Emr.Model.V20160408
{
    public class ListUserStatisticsRequest : RpcAcsRequest<ListUserStatisticsResponse>
    {
        public ListUserStatisticsRequest()
            : base("Emr", "2016-04-08", "ListUserStatistics", "emr", "openAPI")
        {
        }

		private long? resourceOwnerId;

		private string regionId;

		private string orderMode;

		private int? pageSize;

		private string orderFieldName;

		private int? currentSize;

		private string accessKeyId;

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

		public string RegionId
		{
			get
			{
				return regionId;
			}
			set	
			{
				regionId = value;
				DictionaryUtil.Add(QueryParameters, "RegionId", value);
			}
		}

		public string OrderMode
		{
			get
			{
				return orderMode;
			}
			set	
			{
				orderMode = value;
				DictionaryUtil.Add(QueryParameters, "OrderMode", value);
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

		public string OrderFieldName
		{
			get
			{
				return orderFieldName;
			}
			set	
			{
				orderFieldName = value;
				DictionaryUtil.Add(QueryParameters, "OrderFieldName", value);
			}
		}

		public int? CurrentSize
		{
			get
			{
				return currentSize;
			}
			set	
			{
				currentSize = value;
				DictionaryUtil.Add(QueryParameters, "CurrentSize", value.ToString());
			}
		}

		public string AccessKeyId
		{
			get
			{
				return accessKeyId;
			}
			set	
			{
				accessKeyId = value;
				DictionaryUtil.Add(QueryParameters, "AccessKeyId", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ListUserStatisticsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ListUserStatisticsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
