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
using Aliyun.Acs.BssOpenApi.Transform;
using Aliyun.Acs.BssOpenApi.Transform.V20171214;
using System.Collections.Generic;

namespace Aliyun.Acs.BssOpenApi.Model.V20171214
{
    public class SetEnduserStatusRequest : RpcAcsRequest<SetEnduserStatusResponse>
    {
        public SetEnduserStatusRequest()
            : base("BssOpenApi", "2017-12-14", "SetEnduserStatus")
        {
        }

		private long? uid;

		private string primaryAccount;

		private string status;

		private string businessType;

		public long? Uid
		{
			get
			{
				return uid;
			}
			set	
			{
				uid = value;
				DictionaryUtil.Add(QueryParameters, "Uid", value.ToString());
			}
		}

		public string PrimaryAccount
		{
			get
			{
				return primaryAccount;
			}
			set	
			{
				primaryAccount = value;
				DictionaryUtil.Add(QueryParameters, "PrimaryAccount", value);
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

		public string BusinessType
		{
			get
			{
				return businessType;
			}
			set	
			{
				businessType = value;
				DictionaryUtil.Add(QueryParameters, "BusinessType", value);
			}
		}

        public override SetEnduserStatusResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return SetEnduserStatusResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}