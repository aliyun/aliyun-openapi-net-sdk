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
    public class UpdateDictResponseUnmarshaller
    {
        public static UpdateDictResponse Unmarshall(UnmarshallerContext context)
        {
			UpdateDictResponse updateDictResponse = new UpdateDictResponse();

			updateDictResponse.HttpResponse = context.HttpResponse;
			updateDictResponse.RequestId = context.StringValue("UpdateDict.RequestId");

			List<UpdateDictResponse.UpdateDict_DictList> updateDictResponse_result = new List<UpdateDictResponse.UpdateDict_DictList>();
			for (int i = 0; i < context.Length("UpdateDict.Result.Length"); i++) {
				UpdateDictResponse.UpdateDict_DictList dictList = new UpdateDictResponse.UpdateDict_DictList();
				dictList.Name = context.StringValue("UpdateDict.Result["+ i +"].Name");
				dictList.FileSize = context.LongValue("UpdateDict.Result["+ i +"].FileSize");
				dictList.Type = context.StringValue("UpdateDict.Result["+ i +"].Type");
				dictList.SourceType = context.StringValue("UpdateDict.Result["+ i +"].SourceType");

				UpdateDictResponse.UpdateDict_DictList.UpdateDict_OssObject ossObject = new UpdateDictResponse.UpdateDict_DictList.UpdateDict_OssObject();
				ossObject.BucketName = context.StringValue("UpdateDict.Result["+ i +"].OssObject.BucketName");
				ossObject.Key = context.StringValue("UpdateDict.Result["+ i +"].OssObject.Key");
				ossObject.Etag = context.StringValue("UpdateDict.Result["+ i +"].OssObject.Etag");
				dictList.OssObject = ossObject;

				updateDictResponse_result.Add(dictList);
			}
			updateDictResponse.Result = updateDictResponse_result;
        
			return updateDictResponse;
        }
    }
}
