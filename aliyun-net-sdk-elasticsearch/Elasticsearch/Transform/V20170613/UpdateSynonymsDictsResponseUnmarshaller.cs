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
using Aliyun.Acs.elasticsearch.Model.V20170613;

namespace Aliyun.Acs.elasticsearch.Transform.V20170613
{
    public class UpdateSynonymsDictsResponseUnmarshaller
    {
        public static UpdateSynonymsDictsResponse Unmarshall(UnmarshallerContext context)
        {
			UpdateSynonymsDictsResponse updateSynonymsDictsResponse = new UpdateSynonymsDictsResponse();

			updateSynonymsDictsResponse.HttpResponse = context.HttpResponse;
			updateSynonymsDictsResponse.RequestId = context.StringValue("UpdateSynonymsDicts.RequestId");

			List<UpdateSynonymsDictsResponse.UpdateSynonymsDicts_DictList> updateSynonymsDictsResponse_result = new List<UpdateSynonymsDictsResponse.UpdateSynonymsDicts_DictList>();
			for (int i = 0; i < context.Length("UpdateSynonymsDicts.Result.Length"); i++) {
				UpdateSynonymsDictsResponse.UpdateSynonymsDicts_DictList dictList = new UpdateSynonymsDictsResponse.UpdateSynonymsDicts_DictList();
				dictList.Name = context.StringValue("UpdateSynonymsDicts.Result["+ i +"].name");
				dictList.FileSize = context.LongValue("UpdateSynonymsDicts.Result["+ i +"].fileSize");
				dictList.Type = context.StringValue("UpdateSynonymsDicts.Result["+ i +"].type");
				dictList.SourceType = context.StringValue("UpdateSynonymsDicts.Result["+ i +"].sourceType");

				UpdateSynonymsDictsResponse.UpdateSynonymsDicts_DictList.UpdateSynonymsDicts_OssObject ossObject = new UpdateSynonymsDictsResponse.UpdateSynonymsDicts_DictList.UpdateSynonymsDicts_OssObject();
				ossObject.BucketName = context.StringValue("UpdateSynonymsDicts.Result["+ i +"].OssObject.bucketName");
				ossObject.Key = context.StringValue("UpdateSynonymsDicts.Result["+ i +"].OssObject.key");
				ossObject.Etag = context.StringValue("UpdateSynonymsDicts.Result["+ i +"].OssObject.etag");
				dictList.OssObject = ossObject;

				updateSynonymsDictsResponse_result.Add(dictList);
			}
			updateSynonymsDictsResponse.Result = updateSynonymsDictsResponse_result;
        
			return updateSynonymsDictsResponse;
        }
    }
}
