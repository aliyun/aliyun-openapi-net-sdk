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
    public class UpLoadMapRequest : RpcAcsRequest<UpLoadMapResponse>
    {
        public UpLoadMapRequest()
            : base("cloudwf", "2017-03-28", "UpLoadMap", "cloudwf", "openAPI")
        {
        }

		private string fileName;

		private string uploadId;

		private string objectName;

		private int? chunkIndex;

		private string accessKeyId;

		private int? chunkCnt;

		public string FileName
		{
			get
			{
				return fileName;
			}
			set	
			{
				fileName = value;
				DictionaryUtil.Add(QueryParameters, "FileName", value);
			}
		}

		public string UploadId
		{
			get
			{
				return uploadId;
			}
			set	
			{
				uploadId = value;
				DictionaryUtil.Add(QueryParameters, "UploadId", value);
			}
		}

		public string ObjectName
		{
			get
			{
				return objectName;
			}
			set	
			{
				objectName = value;
				DictionaryUtil.Add(QueryParameters, "ObjectName", value);
			}
		}

		public int? ChunkIndex
		{
			get
			{
				return chunkIndex;
			}
			set	
			{
				chunkIndex = value;
				DictionaryUtil.Add(QueryParameters, "ChunkIndex", value.ToString());
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

		public int? ChunkCnt
		{
			get
			{
				return chunkCnt;
			}
			set	
			{
				chunkCnt = value;
				DictionaryUtil.Add(QueryParameters, "ChunkCnt", value.ToString());
			}
		}

        public override UpLoadMapResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return UpLoadMapResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
