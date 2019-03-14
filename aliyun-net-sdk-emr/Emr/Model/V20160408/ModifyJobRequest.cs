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
    public class ModifyJobRequest : RpcAcsRequest<ModifyJobResponse>
    {
        public ModifyJobRequest()
            : base("Emr", "2016-04-08", "ModifyJob", "emr", "openAPI")
        {
        }

		private string runParameter;

		private int? retryInterval;

		private long? resourceOwnerId;

		private string regionId;

		private string name;

		private string id;

		private string type;

		private int? maxRetry;

		private string accessKeyId;

		private string failAct;

		public string RunParameter
		{
			get
			{
				return runParameter;
			}
			set	
			{
				runParameter = value;
				DictionaryUtil.Add(QueryParameters, "RunParameter", value);
			}
		}

		public int? RetryInterval
		{
			get
			{
				return retryInterval;
			}
			set	
			{
				retryInterval = value;
				DictionaryUtil.Add(QueryParameters, "RetryInterval", value.ToString());
			}
		}

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

		public string Type
		{
			get
			{
				return type;
			}
			set	
			{
				type = value;
				DictionaryUtil.Add(QueryParameters, "Type", value);
			}
		}

		public int? MaxRetry
		{
			get
			{
				return maxRetry;
			}
			set	
			{
				maxRetry = value;
				DictionaryUtil.Add(QueryParameters, "MaxRetry", value.ToString());
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

		public string FailAct
		{
			get
			{
				return failAct;
			}
			set	
			{
				failAct = value;
				DictionaryUtil.Add(QueryParameters, "FailAct", value);
			}
		}

        public override ModifyJobResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ModifyJobResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
