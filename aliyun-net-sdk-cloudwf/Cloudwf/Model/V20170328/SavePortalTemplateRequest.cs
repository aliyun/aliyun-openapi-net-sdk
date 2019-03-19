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
    public class SavePortalTemplateRequest : RpcAcsRequest<SavePortalTemplateResponse>
    {
        public SavePortalTemplateRequest()
            : base("cloudwf", "2017-03-28", "SavePortalTemplate", "cloudwf", "openAPI")
        {
        }

		private string textContent;

		private string tempName;

		private string textAlign;

		private string textColor;

		private long? id;

		private long? ossFileId;

		private string accessKeyId;

		public string TextContent
		{
			get
			{
				return textContent;
			}
			set	
			{
				textContent = value;
				DictionaryUtil.Add(QueryParameters, "TextContent", value);
			}
		}

		public string TempName
		{
			get
			{
				return tempName;
			}
			set	
			{
				tempName = value;
				DictionaryUtil.Add(QueryParameters, "TempName", value);
			}
		}

		public string TextAlign
		{
			get
			{
				return textAlign;
			}
			set	
			{
				textAlign = value;
				DictionaryUtil.Add(QueryParameters, "TextAlign", value);
			}
		}

		public string TextColor
		{
			get
			{
				return textColor;
			}
			set	
			{
				textColor = value;
				DictionaryUtil.Add(QueryParameters, "TextColor", value);
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

		public long? OssFileId
		{
			get
			{
				return ossFileId;
			}
			set	
			{
				ossFileId = value;
				DictionaryUtil.Add(QueryParameters, "OssFileId", value.ToString());
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

        public override SavePortalTemplateResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return SavePortalTemplateResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
