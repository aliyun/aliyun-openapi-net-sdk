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
    public class ListJobExecutionPlanParamsRequest : RpcAcsRequest<ListJobExecutionPlanParamsResponse>
    {
        public ListJobExecutionPlanParamsRequest()
            : base("Emr", "2016-04-08", "ListJobExecutionPlanParams", "emr", "openAPI")
        {
        }

		private long? resourceOwnerId;

		private string relateId;

		private string accessKeyId;

		private string paramBizType;

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

		public string RelateId
		{
			get
			{
				return relateId;
			}
			set	
			{
				relateId = value;
				DictionaryUtil.Add(QueryParameters, "RelateId", value);
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

		public string ParamBizType
		{
			get
			{
				return paramBizType;
			}
			set	
			{
				paramBizType = value;
				DictionaryUtil.Add(QueryParameters, "ParamBizType", value);
			}
		}

        public override ListJobExecutionPlanParamsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ListJobExecutionPlanParamsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
