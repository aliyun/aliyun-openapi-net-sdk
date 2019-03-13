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
using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.xspace.Transform;
using Aliyun.Acs.xspace.Transform.V20170720;
using System.Collections.Generic;

namespace Aliyun.Acs.xspace.Model.V20170720
{
    public class QueryCustomerByPhoneRequest : RoaAcsRequest<QueryCustomerByPhoneResponse>
    {
        public QueryCustomerByPhoneRequest()
            : base("xspace", "2017-07-20", "QueryCustomerByPhone")
        {
			UriPattern = "/customerbyphone";
			Method = MethodType.POST;
        }

		private string phone;

		public string Phone
		{
			get
			{
				return phone;
			}
			set	
			{
				phone = value;
				DictionaryUtil.Add(QueryParameters, "Phone", value);
			}
		}

        public override QueryCustomerByPhoneResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return QueryCustomerByPhoneResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}