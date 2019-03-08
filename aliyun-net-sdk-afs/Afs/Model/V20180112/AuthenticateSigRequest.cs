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
using Aliyun.Acs.afs.Transform;
using Aliyun.Acs.afs.Transform.V20180112;
using System.Collections.Generic;

namespace Aliyun.Acs.afs.Model.V20180112
{
    public class AuthenticateSigRequest : RpcAcsRequest<AuthenticateSigResponse>
    {
        public AuthenticateSigRequest()
            : base("afs", "2018-01-12", "AuthenticateSig")
        {
        }

		private string sig;

		private string remoteIp;

		private string sourceIp;

		private string appKey;

		private string sessionId;

		private string token;

		private string scene;

		public string Sig
		{
			get
			{
				return sig;
			}
			set	
			{
				sig = value;
				DictionaryUtil.Add(QueryParameters, "Sig", value);
			}
		}

		public string RemoteIp
		{
			get
			{
				return remoteIp;
			}
			set	
			{
				remoteIp = value;
				DictionaryUtil.Add(QueryParameters, "RemoteIp", value);
			}
		}

		public string SourceIp
		{
			get
			{
				return sourceIp;
			}
			set	
			{
				sourceIp = value;
				DictionaryUtil.Add(QueryParameters, "SourceIp", value);
			}
		}

		public string AppKey
		{
			get
			{
				return appKey;
			}
			set	
			{
				appKey = value;
				DictionaryUtil.Add(QueryParameters, "AppKey", value);
			}
		}

		public string SessionId
		{
			get
			{
				return sessionId;
			}
			set	
			{
				sessionId = value;
				DictionaryUtil.Add(QueryParameters, "SessionId", value);
			}
		}

		public string Token
		{
			get
			{
				return token;
			}
			set	
			{
				token = value;
				DictionaryUtil.Add(QueryParameters, "Token", value);
			}
		}

		public string Scene
		{
			get
			{
				return scene;
			}
			set	
			{
				scene = value;
				DictionaryUtil.Add(QueryParameters, "Scene", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override AuthenticateSigResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return AuthenticateSigResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}