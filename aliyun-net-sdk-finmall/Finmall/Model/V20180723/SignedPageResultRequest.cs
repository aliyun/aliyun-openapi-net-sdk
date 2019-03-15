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
    public class SignedPageResultRequest : RpcAcsRequest<SignedPageResultResponse>
    {
        public SignedPageResultRequest()
            : base("finmall", "2018-07-23", "SignedPageResult", "finmall", "openAPI")
        {
			Method = MethodType.POST;
        }

		private string downloadUrl;

		private string digest;

		private string viewUrl;

		private int? resultCode;

		private string transactionId;

		private string resultDesc;

		private string timestamp;

		public string DownloadUrl
		{
			get
			{
				return downloadUrl;
			}
			set	
			{
				downloadUrl = value;
				DictionaryUtil.Add(QueryParameters, "DownloadUrl", value);
			}
		}

		public string Digest
		{
			get
			{
				return digest;
			}
			set	
			{
				digest = value;
				DictionaryUtil.Add(QueryParameters, "Digest", value);
			}
		}

		public string ViewUrl
		{
			get
			{
				return viewUrl;
			}
			set	
			{
				viewUrl = value;
				DictionaryUtil.Add(QueryParameters, "ViewUrl", value);
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

		public string Timestamp
		{
			get
			{
				return timestamp;
			}
			set	
			{
				timestamp = value;
				DictionaryUtil.Add(QueryParameters, "Timestamp", value);
			}
		}

        public override SignedPageResultResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return SignedPageResultResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
