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
using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.vs.Model.V20181212;

namespace Aliyun.Acs.vs.Transform.V20181212
{
    public class ListObjectsResponseUnmarshaller
    {
        public static ListObjectsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListObjectsResponse listObjectsResponse = new ListObjectsResponse();

			listObjectsResponse.HttpResponse = _ctx.HttpResponse;
			listObjectsResponse.RequestId = _ctx.StringValue("ListObjects.RequestId");
			listObjectsResponse.BucketName = _ctx.StringValue("ListObjects.BucketName");
			listObjectsResponse.Prefix = _ctx.StringValue("ListObjects.Prefix");
			listObjectsResponse.MaxKeys = _ctx.IntegerValue("ListObjects.MaxKeys");
			listObjectsResponse.KeyCount = _ctx.IntegerValue("ListObjects.KeyCount");
			listObjectsResponse.Delimiter = _ctx.StringValue("ListObjects.Delimiter");
			listObjectsResponse.EncodingType = _ctx.StringValue("ListObjects.EncodingType");
			listObjectsResponse.IsTruncated = _ctx.BooleanValue("ListObjects.IsTruncated");
			listObjectsResponse.ContinuationToken = _ctx.StringValue("ListObjects.ContinuationToken");
			listObjectsResponse.NextContinuationToken = _ctx.StringValue("ListObjects.NextContinuationToken");
			listObjectsResponse.Marker = _ctx.StringValue("ListObjects.Marker");
			listObjectsResponse.NextMarker = _ctx.StringValue("ListObjects.NextMarker");

			List<string> listObjectsResponse_commonPrefixes = new List<string>();
			for (int i = 0; i < _ctx.Length("ListObjects.CommonPrefixes.Length"); i++) {
				listObjectsResponse_commonPrefixes.Add(_ctx.StringValue("ListObjects.CommonPrefixes["+ i +"]"));
			}
			listObjectsResponse.CommonPrefixes = listObjectsResponse_commonPrefixes;

			List<ListObjectsResponse.ListObjects_Content> listObjectsResponse_contents = new List<ListObjectsResponse.ListObjects_Content>();
			for (int i = 0; i < _ctx.Length("ListObjects.Contents.Length"); i++) {
				ListObjectsResponse.ListObjects_Content content = new ListObjectsResponse.ListObjects_Content();
				content.Key = _ctx.StringValue("ListObjects.Contents["+ i +"].Key");
				content.LastModified = _ctx.StringValue("ListObjects.Contents["+ i +"].LastModified");
				content.ETag = _ctx.StringValue("ListObjects.Contents["+ i +"].ETag");
				content.Size = _ctx.LongValue("ListObjects.Contents["+ i +"].Size");
				content.StorageClass = _ctx.StringValue("ListObjects.Contents["+ i +"].StorageClass");

				listObjectsResponse_contents.Add(content);
			}
			listObjectsResponse.Contents = listObjectsResponse_contents;
        
			return listObjectsResponse;
        }
    }
}
