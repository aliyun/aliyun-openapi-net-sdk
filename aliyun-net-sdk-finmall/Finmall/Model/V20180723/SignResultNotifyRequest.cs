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
using Aliyun.Acs.finmall.Transform;
using Aliyun.Acs.finmall.Transform.V20180723;

namespace Aliyun.Acs.finmall.Model.V20180723
{
    public class SignResultNotifyRequest : RpcAcsRequest<SignResultNotifyResponse>
    {
        public SignResultNotifyRequest()
            : base("finmall", "2018-07-23", "SignResultNotify", "finmall", "openAPI")
        {
			Method = MethodType.POST;
        }

		private string docId;

		private string docContent;

		private string sign;

		private int? resultCode;

		private long? time;

		private string transactionId;

		private string resultDesc;

		public string DocId
		{
			get
			{
				return docId;
			}
			set	
			{
				docId = value;
				DictionaryUtil.Add(QueryParameters, "DocId", value);
			}
		}

		public string DocContent
		{
			get
			{
				return docContent;
			}
			set	
			{
				docContent = value;
				DictionaryUtil.Add(BodyParameters, "DocContent", value);
			}
		}

		public string Sign
		{
			get
			{
				return sign;
			}
			set	
			{
				sign = value;
				DictionaryUtil.Add(QueryParameters, "Sign", value);
			}
		}

		public int? ResultCode
		{
			get
			{
				return resultCode;
			}
			set	
			{
				resultCode = value;
				DictionaryUtil.Add(QueryParameters, "ResultCode", value.ToString());
			}
		}

		public long? Time
		{
			get
			{
				return time;
			}
			set	
			{
				time = value;
				DictionaryUtil.Add(QueryParameters, "Time", value.ToString());
			}
		}

		public string TransactionId
		{
			get
			{
				return transactionId;
			}
			set	
			{
				transactionId = value;
				DictionaryUtil.Add(QueryParameters, "TransactionId", value);
			}
		}

		public string ResultDesc
		{
			get
			{
				return resultDesc;
			}
			set	
			{
				resultDesc = value;
				DictionaryUtil.Add(QueryParameters, "ResultDesc", value);
			}
		}

        public override SignResultNotifyResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return SignResultNotifyResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
