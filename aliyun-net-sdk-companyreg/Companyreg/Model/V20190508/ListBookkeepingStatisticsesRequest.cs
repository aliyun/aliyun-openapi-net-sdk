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
using Aliyun.Acs.companyreg.Transform;
using Aliyun.Acs.companyreg.Transform.V20190508;

namespace Aliyun.Acs.companyreg.Model.V20190508
{
    public class ListBookkeepingStatisticsesRequest : RpcAcsRequest<ListBookkeepingStatisticsesResponse>
    {
        public ListBookkeepingStatisticsesRequest()
            : base("companyreg", "2019-05-08", "ListBookkeepingStatisticses", "companyreg", "openAPI")
        {
        }

		private int? year;

		private string produceBizId;

		private int? pageNumber;

		private int? month;

		private int? pageSize;

		public int? Year
		{
			get
			{
				return year;
			}
			set	
			{
				year = value;
				DictionaryUtil.Add(QueryParameters, "Year", value.ToString());
			}
		}

		public string ProduceBizId
		{
			get
			{
				return produceBizId;
			}
			set	
			{
				produceBizId = value;
				DictionaryUtil.Add(QueryParameters, "ProduceBizId", value);
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

		public int? Month
		{
			get
			{
				return month;
			}
			set	
			{
				month = value;
				DictionaryUtil.Add(QueryParameters, "Month", value.ToString());
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

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ListBookkeepingStatisticsesResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ListBookkeepingStatisticsesResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
