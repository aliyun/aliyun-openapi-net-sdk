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
using Aliyun.Acs.lto;
using Aliyun.Acs.lto.Transform;
using Aliyun.Acs.lto.Transform.V20210707;

namespace Aliyun.Acs.lto.Model.V20210707
{
    public class QueryBlockchainDataRequest : RpcAcsRequest<QueryBlockchainDataResponse>
    {
        public QueryBlockchainDataRequest()
            : base("lto", "2021-07-07", "QueryBlockchainData")
        {
			Method = MethodType.POST;
        }

		private string contractName;

		private string bizChainId;

		private string transactionId;

		private string invokeType;

		private string iotDataDID;

		public string ContractName
		{
			get
			{
				return contractName;
			}
			set	
			{
				contractName = value;
				DictionaryUtil.Add(QueryParameters, "ContractName", value);
			}
		}

		public string BizChainId
		{
			get
			{
				return bizChainId;
			}
			set	
			{
				bizChainId = value;
				DictionaryUtil.Add(QueryParameters, "BizChainId", value);
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

		public string InvokeType
		{
			get
			{
				return invokeType;
			}
			set	
			{
				invokeType = value;
				DictionaryUtil.Add(QueryParameters, "InvokeType", value);
			}
		}

		public string IotDataDID
		{
			get
			{
				return iotDataDID;
			}
			set	
			{
				iotDataDID = value;
				DictionaryUtil.Add(QueryParameters, "IotDataDID", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override QueryBlockchainDataResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return QueryBlockchainDataResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
