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
using Aliyun.Acs.Cloudauth.Transform.V20180916;
using System.Collections.Generic;

namespace Aliyun.Acs.Cloudauth.Model.V20180916
{
    public class DetectFaceAttributesRequest : RpcAcsRequest<DetectFaceAttributesResponse>
    {
        public DetectFaceAttributesRequest()
            : base("Cloudauth", "2018-09-16", "DetectFaceAttributes", "CloudAuth", "openAPI")
        {
			Protocol = ProtocolType.HTTPS;
			Method = MethodType.POST;
        }

		private int? maxNumPhotosPerCategory;

		private int? maxFaceNum;

		private long? resourceOwnerId;

		private string sourceIp;

		private string retAttributes;

		private string materialValue;

		private bool? dontSaveDB;

		private string clientTag;

		public int? MaxNumPhotosPerCategory
		{
			get
			{
				return maxNumPhotosPerCategory;
			}
			set	
			{
				maxNumPhotosPerCategory = value;
				DictionaryUtil.Add(BodyParameters, "MaxNumPhotosPerCategory", value.ToString());
			}
		}

		public int? MaxFaceNum
		{
			get
			{
				return maxFaceNum;
			}
			set	
			{
				maxFaceNum = value;
				DictionaryUtil.Add(BodyParameters, "MaxFaceNum", value.ToString());
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

		public string RetAttributes
		{
			get
			{
				return retAttributes;
			}
			set	
			{
				retAttributes = value;
				DictionaryUtil.Add(BodyParameters, "RetAttributes", value);
			}
		}

		public string MaterialValue
		{
			get
			{
				return materialValue;
			}
			set	
			{
				materialValue = value;
				DictionaryUtil.Add(BodyParameters, "MaterialValue", value);
			}
		}

		public bool? DontSaveDB
		{
			get
			{
				return dontSaveDB;
			}
			set	
			{
				dontSaveDB = value;
				DictionaryUtil.Add(BodyParameters, "DontSaveDB", value.ToString());
			}
		}

		public string ClientTag
		{
			get
			{
				return clientTag;
			}
			set	
			{
				clientTag = value;
				DictionaryUtil.Add(BodyParameters, "ClientTag", value);
			}
		}

        public override DetectFaceAttributesResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return DetectFaceAttributesResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}