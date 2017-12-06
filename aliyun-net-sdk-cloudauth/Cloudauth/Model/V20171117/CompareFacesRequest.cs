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
using Aliyun.Acs.Cloudauth.Transform;
using Aliyun.Acs.Cloudauth.Transform.V20171117;
using System.Collections.Generic;

namespace Aliyun.Acs.Cloudauth.Model.V20171117
{
    public class CompareFacesRequest : RpcAcsRequest<CompareFacesResponse>
    {
        public CompareFacesRequest()
            : base("Cloudauth", "2017-11-17", "CompareFaces", "cloudauth", "openAPI")
        {
			Protocol = ProtocolType.HTTPS;
        }

		private string sourceImageType;

		private long? resourceOwnerId;

		private string targetImageType;

		private string sourceImageValue;

		private string targetImageValue;

		public string SourceImageType
		{
			get
			{
				return sourceImageType;
			}
			set	
			{
				sourceImageType = value;
				DictionaryUtil.Add(QueryParameters, "SourceImageType", value);
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

		public string TargetImageType
		{
			get
			{
				return targetImageType;
			}
			set	
			{
				targetImageType = value;
				DictionaryUtil.Add(QueryParameters, "TargetImageType", value);
			}
		}

		public string SourceImageValue
		{
			get
			{
				return sourceImageValue;
			}
			set	
			{
				sourceImageValue = value;
				DictionaryUtil.Add(QueryParameters, "SourceImageValue", value);
			}
		}

		public string TargetImageValue
		{
			get
			{
				return targetImageValue;
			}
			set	
			{
				targetImageValue = value;
				DictionaryUtil.Add(QueryParameters, "TargetImageValue", value);
			}
		}

        public override CompareFacesResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return CompareFacesResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}