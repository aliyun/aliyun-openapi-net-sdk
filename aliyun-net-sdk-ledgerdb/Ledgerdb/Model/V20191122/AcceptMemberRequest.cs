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
using Aliyun.Acs.ledgerdb.Transform;
using Aliyun.Acs.ledgerdb.Transform.V20191122;

namespace Aliyun.Acs.ledgerdb.Model.V20191122
{
    public class AcceptMemberRequest : RpcAcsRequest<AcceptMemberResponse>
    {
        public AcceptMemberRequest()
            : base("ledgerdb", "2019-11-22", "AcceptMember", "ledgerdb", "openAPI")
        {
			Method = MethodType.POST;
        }

		private string publicKey;

		private string keyType;

		private string ledgerId;

		public string PublicKey
		{
			get
			{
				return publicKey;
			}
			set	
			{
				publicKey = value;
				DictionaryUtil.Add(BodyParameters, "PublicKey", value);
			}
		}

		public string KeyType
		{
			get
			{
				return keyType;
			}
			set	
			{
				keyType = value;
				DictionaryUtil.Add(BodyParameters, "KeyType", value);
			}
		}

		public string LedgerId
		{
			get
			{
				return ledgerId;
			}
			set	
			{
				ledgerId = value;
				DictionaryUtil.Add(BodyParameters, "LedgerId", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override AcceptMemberResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return AcceptMemberResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
