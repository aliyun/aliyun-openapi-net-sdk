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
using Aliyun.Acs.DdosDiversion;
using Aliyun.Acs.DdosDiversion.Transform;
using Aliyun.Acs.DdosDiversion.Transform.V20230701;

namespace Aliyun.Acs.DdosDiversion.Model.V20230701
{
    public class ListInstanceRequest : RpcAcsRequest<ListInstanceResponse>
    {
        public ListInstanceRequest()
            : base("DdosDiversion", "2023-07-01", "ListInstance")
        {
			Method = MethodType.POST;
        }

		private long? num;

		private string saleId;

		private string name;

		private long? page;

		private string status;

		public long? Num
		{
			get
			{
				return num;
			}
			set	
			{
				num = value;
				DictionaryUtil.Add(QueryParameters, "Num", value.ToString());
			}
		}

		public string SaleId
		{
			get
			{
				return saleId;
			}
			set	
			{
				saleId = value;
				DictionaryUtil.Add(QueryParameters, "SaleId", value);
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

		public long? Page
		{
			get
			{
				return page;
			}
			set	
			{
				page = value;
				DictionaryUtil.Add(QueryParameters, "Page", value.ToString());
			}
		}

		public string Status
		{
			get
			{
				return status;
			}
			set	
			{
				status = value;
				DictionaryUtil.Add(QueryParameters, "Status", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ListInstanceResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ListInstanceResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
