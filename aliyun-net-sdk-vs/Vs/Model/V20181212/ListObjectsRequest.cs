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
using Aliyun.Acs.vs.Transform;
using Aliyun.Acs.vs.Transform.V20181212;

namespace Aliyun.Acs.vs.Model.V20181212
{
    public class ListObjectsRequest : RpcAcsRequest<ListObjectsResponse>
    {
        public ListObjectsRequest()
            : base("vs", "2018-12-12", "ListObjects", "vs", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.vs.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.vs.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private int? maxKeys;

		private string continuationToken;

		private string prefix;

		private string delimiter;

		private string bucketName;

		private string encodingType;

		private string startAfter;

		private long? ownerId;

		private string marker;

		public int? MaxKeys
		{
			get
			{
				return maxKeys;
			}
			set	
			{
				maxKeys = value;
				DictionaryUtil.Add(QueryParameters, "MaxKeys", value.ToString());
			}
		}

		public string ContinuationToken
		{
			get
			{
				return continuationToken;
			}
			set	
			{
				continuationToken = value;
				DictionaryUtil.Add(QueryParameters, "ContinuationToken", value);
			}
		}

		public string Prefix
		{
			get
			{
				return prefix;
			}
			set	
			{
				prefix = value;
				DictionaryUtil.Add(QueryParameters, "Prefix", value);
			}
		}

		public string Delimiter
		{
			get
			{
				return delimiter;
			}
			set	
			{
				delimiter = value;
				DictionaryUtil.Add(QueryParameters, "Delimiter", value);
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
				DictionaryUtil.Add(QueryParameters, "BucketName", value);
			}
		}

		public string EncodingType
		{
			get
			{
				return encodingType;
			}
			set	
			{
				encodingType = value;
				DictionaryUtil.Add(QueryParameters, "EncodingType", value);
			}
		}

		public string StartAfter
		{
			get
			{
				return startAfter;
			}
			set	
			{
				startAfter = value;
				DictionaryUtil.Add(QueryParameters, "StartAfter", value);
			}
		}

		public long? OwnerId
		{
			get
			{
				return ownerId;
			}
			set	
			{
				ownerId = value;
				DictionaryUtil.Add(QueryParameters, "OwnerId", value.ToString());
			}
		}

		public string Marker
		{
			get
			{
				return marker;
			}
			set	
			{
				marker = value;
				DictionaryUtil.Add(QueryParameters, "Marker", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ListObjectsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ListObjectsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
