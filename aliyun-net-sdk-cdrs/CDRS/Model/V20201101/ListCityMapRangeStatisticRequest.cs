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
    public class ListCityMapRangeStatisticRequest : RpcAcsRequest<ListCityMapRangeStatisticResponse>
    {
        public ListCityMapRangeStatisticRequest()
            : base("CDRS", "2020-11-01", "ListCityMapRangeStatistic")
        {
			Method = MethodType.POST;
        }

		private string latitude;

		private string endTime;

		private long? pageNumber;

		private long? pageSize;

		private int? radius;

		private string longitude;

		public string Latitude
		{
			get
			{
				return latitude;
			}
			set	
			{
				latitude = value;
				DictionaryUtil.Add(BodyParameters, "Latitude", value);
			}
		}

		public string EndTime
		{
			get
			{
				return endTime;
			}
			set	
			{
				endTime = value;
				DictionaryUtil.Add(BodyParameters, "EndTime", value);
			}
		}

		public long? PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
				DictionaryUtil.Add(BodyParameters, "PageNumber", value.ToString());
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

		public int? Radius
		{
			get
			{
				return radius;
			}
			set	
			{
				radius = value;
				DictionaryUtil.Add(BodyParameters, "Radius", value.ToString());
			}
		}

		public string Longitude
		{
			get
			{
				return longitude;
			}
			set	
			{
				longitude = value;
				DictionaryUtil.Add(BodyParameters, "Longitude", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ListCityMapRangeStatisticResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ListCityMapRangeStatisticResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
