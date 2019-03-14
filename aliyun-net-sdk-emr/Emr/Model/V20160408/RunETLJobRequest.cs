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
using Aliyun.Acs.Emr.Transform;
using Aliyun.Acs.Emr.Transform.V20160408;

namespace Aliyun.Acs.Emr.Model.V20160408
{
    public class RunETLJobRequest : RpcAcsRequest<RunETLJobResponse>
    {
        public RunETLJobRequest()
            : base("Emr", "2016-04-08", "RunETLJob", "emr", "openAPI")
        {
        }

		private long? resourceOwnerId;

		private List<InstanceRunParam> instanceRunParams;

		private string regionId;

		private bool? isDebug;

		private string id;

		private string accessKeyId;

		public long? ResourceOwnerId
		{
			get
			{
				return resourceOwnerId;
			}
			set	
			{
				resourceOwnerId = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerId", value.ToString());
			}
		}

		public List<InstanceRunParam> InstanceRunParams
		{
			get
			{
				return instanceRunParams;
			}

			set
			{
				instanceRunParams = value;
				for (int i = 0; i < instanceRunParams.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"InstanceRunParam." + (i + 1) + ".Value", instanceRunParams[i].Value);
					DictionaryUtil.Add(QueryParameters,"InstanceRunParam." + (i + 1) + ".Key", instanceRunParams[i].Key);
				}
			}
		}

		public string RegionId
		{
			get
			{
				return regionId;
			}
			set	
			{
				regionId = value;
				DictionaryUtil.Add(QueryParameters, "RegionId", value);
			}
		}

		public bool? IsDebug
		{
			get
			{
				return isDebug;
			}
			set	
			{
				isDebug = value;
				DictionaryUtil.Add(QueryParameters, "IsDebug", value.ToString());
			}
		}

		public string Id
		{
			get
			{
				return id;
			}
			set	
			{
				id = value;
				DictionaryUtil.Add(QueryParameters, "Id", value);
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

		public class InstanceRunParam
		{

			private string value_;

			private string key;

			public string Value
			{
				get
				{
					return value_;
				}
				set	
				{
					value_ = value;
				}
			}

			public string Key
			{
				get
				{
					return key;
				}
				set	
				{
					key = value;
				}
			}
		}

        public override RunETLJobResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return RunETLJobResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
