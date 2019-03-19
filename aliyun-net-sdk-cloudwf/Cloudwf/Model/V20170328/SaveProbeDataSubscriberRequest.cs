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
using Aliyun.Acs.cloudwf.Transform;
using Aliyun.Acs.cloudwf.Transform.V20170328;

namespace Aliyun.Acs.cloudwf.Model.V20170328
{
    public class SaveProbeDataSubscriberRequest : RpcAcsRequest<SaveProbeDataSubscriberResponse>
    {
        public SaveProbeDataSubscriberRequest()
            : base("cloudwf", "2017-03-28", "SaveProbeDataSubscriber", "cloudwf", "openAPI")
        {
        }

		private string apiUrl;

		private string paramGenScript;

		private string name;

		private string httpMethod;

		private string description;

		private long? id;

		private int? type;

		private string accessKeyId;

		private List<long?> resourceIdss;

		public string ApiUrl
		{
			get
			{
				return apiUrl;
			}
			set	
			{
				apiUrl = value;
				DictionaryUtil.Add(QueryParameters, "ApiUrl", value);
			}
		}

		public string ParamGenScript
		{
			get
			{
				return paramGenScript;
			}
			set	
			{
				paramGenScript = value;
				DictionaryUtil.Add(QueryParameters, "ParamGenScript", value);
			}
		}

		public string Name
		{
			get
			{
				return name;
			}
			set	
			{
				name = value;
				DictionaryUtil.Add(QueryParameters, "Name", value);
			}
		}

		public string HttpMethod
		{
			get
			{
				return httpMethod;
			}
			set	
			{
				httpMethod = value;
				DictionaryUtil.Add(QueryParameters, "HttpMethod", value);
			}
		}

		public string Description
		{
			get
			{
				return description;
			}
			set	
			{
				description = value;
				DictionaryUtil.Add(QueryParameters, "Description", value);
			}
		}

		public long? Id
		{
			get
			{
				return id;
			}
			set	
			{
				id = value;
				DictionaryUtil.Add(QueryParameters, "Id", value.ToString());
			}
		}

		public int? Type
		{
			get
			{
				return type;
			}
			set	
			{
				type = value;
				DictionaryUtil.Add(QueryParameters, "Type", value.ToString());
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

		public List<long?> ResourceIdss
		{
			get
			{
				return resourceIdss;
			}

			set
			{
				resourceIdss = value;
				for (int i = 0; i < resourceIdss.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"ResourceIds." + (i + 1) , resourceIdss[i]);
				}
			}
		}

        public override SaveProbeDataSubscriberResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return SaveProbeDataSubscriberResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
