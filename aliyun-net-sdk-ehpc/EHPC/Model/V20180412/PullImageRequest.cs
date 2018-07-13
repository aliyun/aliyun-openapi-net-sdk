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
    public class PullImageRequest : RpcAcsRequest<PullImageResponse>
    {
        public PullImageRequest()
            : base("EHPC", "2018-04-12", "PullImage", "ehs", "openAPI")
        {
        }

		private string containerType;

		private string action;

		private string clusterId;

		private string repository;

		private string imageTag;

		private string accessKeyId;

		public string ContainerType
		{
			get
			{
				return containerType;
			}
			set	
			{
				containerType = value;
				DictionaryUtil.Add(QueryParameters, "ContainerType", value);
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

		public string Repository
		{
			get
			{
				return repository;
			}
			set	
			{
				repository = value;
				DictionaryUtil.Add(QueryParameters, "Repository", value);
			}
		}

		public string ImageTag
		{
			get
			{
				return imageTag;
			}
			set	
			{
				imageTag = value;
				DictionaryUtil.Add(QueryParameters, "ImageTag", value);
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

        public override PullImageResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return PullImageResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}