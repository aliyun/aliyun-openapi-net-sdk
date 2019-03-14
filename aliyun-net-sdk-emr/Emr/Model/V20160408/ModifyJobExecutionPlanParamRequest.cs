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
    public class ModifyJobExecutionPlanParamRequest : RpcAcsRequest<ModifyJobExecutionPlanParamResponse>
    {
        public ModifyJobExecutionPlanParamRequest()
            : base("Emr", "2016-04-08", "ModifyJobExecutionPlanParam", "emr", "openAPI")
        {
        }

		private long? resourceOwnerId;

		private string paramName;

		private string paramValue;

		private long? id;

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

		public string ParamName
		{
			get
			{
				return paramName;
			}
			set	
			{
				paramName = value;
				DictionaryUtil.Add(QueryParameters, "ParamName", value);
			}
		}

		public string ParamValue
		{
			get
			{
				return paramValue;
			}
			set	
			{
				paramValue = value;
				DictionaryUtil.Add(QueryParameters, "ParamValue", value);
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

        public override ModifyJobExecutionPlanParamResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ModifyJobExecutionPlanParamResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
