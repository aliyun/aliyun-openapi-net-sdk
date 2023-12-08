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
    public class QueryNetListRequest : RpcAcsRequest<QueryNetListResponse>
    {
        public QueryNetListRequest()
            : base("DdosDiversion", "2023-07-01", "QueryNetList")
        {
			Method = MethodType.POST;
        }

		private long? num;

		private string mainNet;

		private string mode;

		private string net;

		private string saleId;

		private long? page;

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

		public string MainNet
		{
			get
			{
				return mainNet;
			}
			set	
			{
				mainNet = value;
				DictionaryUtil.Add(QueryParameters, "MainNet", value);
			}
		}

		public string Mode
		{
			get
			{
				return mode;
			}
			set	
			{
				mode = value;
				DictionaryUtil.Add(QueryParameters, "Mode", value);
			}
		}

		public string Net
		{
			get
			{
				return net;
			}
			set	
			{
				net = value;
				DictionaryUtil.Add(QueryParameters, "Net", value);
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

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override QueryNetListResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return QueryNetListResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
