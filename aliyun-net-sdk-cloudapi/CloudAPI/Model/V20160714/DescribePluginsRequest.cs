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
using Aliyun.Acs.CloudAPI.Transform;
using Aliyun.Acs.CloudAPI.Transform.V20160714;
using System.Collections.Generic;

namespace Aliyun.Acs.CloudAPI.Model.V20160714
{
    public class DescribePluginsRequest : RpcAcsRequest<DescribePluginsResponse>
    {
        public DescribePluginsRequest()
            : base("CloudAPI", "2016-07-14", "DescribePlugins", "apigateway", "openAPI")
        {
        }

		private string pluginType;

		private string pluginName;

		private string securityToken;

		private string pluginId;

		private int? pageSize;

		private string action;

		private int? pageNumber;

		private string accessKeyId;

		public string PluginType
		{
			get
			{
				return pluginType;
			}
			set	
			{
				pluginType = value;
				DictionaryUtil.Add(QueryParameters, "PluginType", value);
			}
		}

		public string PluginName
		{
			get
			{
				return pluginName;
			}
			set	
			{
				pluginName = value;
				DictionaryUtil.Add(QueryParameters, "PluginName", value);
			}
		}

		public string SecurityToken
		{
			get
			{
				return securityToken;
			}
			set	
			{
				securityToken = value;
				DictionaryUtil.Add(QueryParameters, "SecurityToken", value);
			}
		}

		public string PluginId
		{
			get
			{
				return pluginId;
			}
			set	
			{
				pluginId = value;
				DictionaryUtil.Add(QueryParameters, "PluginId", value);
			}
		}

		public int? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
				DictionaryUtil.Add(QueryParameters, "PageSize", value.ToString());
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

		public int? PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
				DictionaryUtil.Add(QueryParameters, "PageNumber", value.ToString());
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

        public override DescribePluginsResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return DescribePluginsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}