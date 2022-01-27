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
using Aliyun.Acs.CDRS;
using Aliyun.Acs.CDRS.Transform;
using Aliyun.Acs.CDRS.Transform.V20201101;

namespace Aliyun.Acs.CDRS.Model.V20201101
{
    public class ListCityMapCameraResultsRequest : RpcAcsRequest<ListCityMapCameraResultsResponse>
    {
        public ListCityMapCameraResultsRequest()
            : base("CDRS", "2020-11-01", "ListCityMapCameraResults")
        {
			Method = MethodType.POST;
        }

		private long? pageNum;

		private List<object> dataSourceIdList;

		private long? pageSize;

		public long? PageNum
		{
			get
			{
				return pageNum;
			}
			set	
			{
				pageNum = value;
				DictionaryUtil.Add(BodyParameters, "PageNum", value.ToString());
			}
		}

		public List<object> DataSourceIdList
		{
			get
			{
				return dataSourceIdList;
			}
			set	
			{
				dataSourceIdList = value;
				DictionaryUtil.Add(BodyParameters, "DataSourceIdList", JsonConvert.SerializeObject(value));
			}
		}

		public long? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
				DictionaryUtil.Add(BodyParameters, "PageSize", value.ToString());
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ListCityMapCameraResultsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ListCityMapCameraResultsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
