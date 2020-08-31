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
using Aliyun.Acs.Vcs;
using Aliyun.Acs.Vcs.Transform;
using Aliyun.Acs.Vcs.Transform.V20200515;

namespace Aliyun.Acs.Vcs.Model.V20200515
{
    public class CreateVideoComposeTaskRequest : RpcAcsRequest<CreateVideoComposeTaskResponse>
    {
        public CreateVideoComposeTaskRequest()
            : base("Vcs", "2020-05-15", "CreateVideoComposeTask")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string corpId;

		private string domainName;

		private int? videoFrameRate;

		private string imageFileNames;

		private string audioFileName;

		private string bucketName;

		private string imageParameters;

		private string videoFormat;

		public string CorpId
		{
			get
			{
				return corpId;
			}
			set	
			{
				corpId = value;
				DictionaryUtil.Add(BodyParameters, "CorpId", value);
			}
		}

		public string DomainName
		{
			get
			{
				return domainName;
			}
			set	
			{
				domainName = value;
				DictionaryUtil.Add(BodyParameters, "DomainName", value);
			}
		}

		public int? VideoFrameRate
		{
			get
			{
				return videoFrameRate;
			}
			set	
			{
				videoFrameRate = value;
				DictionaryUtil.Add(BodyParameters, "VideoFrameRate", value.ToString());
			}
		}

		public string ImageFileNames
		{
			get
			{
				return imageFileNames;
			}
			set	
			{
				imageFileNames = value;
				DictionaryUtil.Add(BodyParameters, "ImageFileNames", value);
			}
		}

		public string AudioFileName
		{
			get
			{
				return audioFileName;
			}
			set	
			{
				audioFileName = value;
				DictionaryUtil.Add(BodyParameters, "AudioFileName", value);
			}
		}

		public string BucketName
		{
			get
			{
				return bucketName;
			}
			set	
			{
				bucketName = value;
				DictionaryUtil.Add(BodyParameters, "BucketName", value);
			}
		}

		public string ImageParameters
		{
			get
			{
				return imageParameters;
			}
			set	
			{
				imageParameters = value;
				DictionaryUtil.Add(BodyParameters, "ImageParameters", value);
			}
		}

		public string VideoFormat
		{
			get
			{
				return videoFormat;
			}
			set	
			{
				videoFormat = value;
				DictionaryUtil.Add(BodyParameters, "VideoFormat", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override CreateVideoComposeTaskResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateVideoComposeTaskResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
