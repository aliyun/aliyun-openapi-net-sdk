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
using Aliyun.Acs.EHPC.Transform;
using Aliyun.Acs.EHPC.Transform.V20180412;
using System.Collections.Generic;

namespace Aliyun.Acs.EHPC.Model.V20180412
{
    public class ModifyImageGatewayConfigRequest : RpcAcsRequest<ModifyImageGatewayConfigResponse>
    {
        public ModifyImageGatewayConfigRequest()
            : base("EHPC", "2018-04-12", "ModifyImageGatewayConfig", "ehs", "openAPI")
        {
        }

		private string defaultRepoLocation;

		private string dBPassword;

		private List<Repo> repos;

		private string dBType;

		private string dBUsername;

		private string action;

		private string dBServerInfo;

		private int? pullUpdateTimeout;

		private string clusterId;

		private string accessKeyId;

		private string imageExpirationTimeout;

		public string DefaultRepoLocation
		{
			get
			{
				return defaultRepoLocation;
			}
			set	
			{
				defaultRepoLocation = value;
				DictionaryUtil.Add(QueryParameters, "DefaultRepoLocation", value);
			}
		}

		public string DBPassword
		{
			get
			{
				return dBPassword;
			}
			set	
			{
				dBPassword = value;
				DictionaryUtil.Add(QueryParameters, "DBPassword", value);
			}
		}

		public List<Repo> Repos
		{
			get
			{
				return repos;
			}

			set
			{
				repos = value;
				for (int i = 0; i < repos.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"Repo." + (i + 1) + ".Location", repos[i].Location);
					DictionaryUtil.Add(QueryParameters,"Repo." + (i + 1) + ".Auth", repos[i].Auth);
					DictionaryUtil.Add(QueryParameters,"Repo." + (i + 1) + ".URL", repos[i].URL);
				}
			}
		}

		public string DBType
		{
			get
			{
				return dBType;
			}
			set	
			{
				dBType = value;
				DictionaryUtil.Add(QueryParameters, "DBType", value);
			}
		}

		public string DBUsername
		{
			get
			{
				return dBUsername;
			}
			set	
			{
				dBUsername = value;
				DictionaryUtil.Add(QueryParameters, "DBUsername", value);
			}
		}

		public string Action
		{
			get
			{
				return action;
			}
			set	
			{
				action = value;
				DictionaryUtil.Add(QueryParameters, "Action", value);
			}
		}

		public string DBServerInfo
		{
			get
			{
				return dBServerInfo;
			}
			set	
			{
				dBServerInfo = value;
				DictionaryUtil.Add(QueryParameters, "DBServerInfo", value);
			}
		}

		public int? PullUpdateTimeout
		{
			get
			{
				return pullUpdateTimeout;
			}
			set	
			{
				pullUpdateTimeout = value;
				DictionaryUtil.Add(QueryParameters, "PullUpdateTimeout", value.ToString());
			}
		}

		public string ClusterId
		{
			get
			{
				return clusterId;
			}
			set	
			{
				clusterId = value;
				DictionaryUtil.Add(QueryParameters, "ClusterId", value);
			}
		}

		public string AccessKeyId
		{
			get
			{
				return accessKeyId;
			}
			set	
			{
				accessKeyId = value;
				DictionaryUtil.Add(QueryParameters, "AccessKeyId", value);
			}
		}

		public string ImageExpirationTimeout
		{
			get
			{
				return imageExpirationTimeout;
			}
			set	
			{
				imageExpirationTimeout = value;
				DictionaryUtil.Add(QueryParameters, "ImageExpirationTimeout", value);
			}
		}

		public class Repo
		{

			private string location;

			private string auth;

			private string uRL;

			public string Location
			{
				get
				{
					return location;
				}
				set	
				{
					location = value;
				}
			}

			public string Auth
			{
				get
				{
					return auth;
				}
				set	
				{
					auth = value;
				}
			}

			public string URL
			{
				get
				{
					return uRL;
				}
				set	
				{
					uRL = value;
				}
			}
		}

        public override ModifyImageGatewayConfigResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return ModifyImageGatewayConfigResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}