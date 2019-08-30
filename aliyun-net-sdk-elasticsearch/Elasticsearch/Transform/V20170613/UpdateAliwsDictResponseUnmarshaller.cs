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
    public class UpdateAliwsDictResponseUnmarshaller
    {
        public static UpdateAliwsDictResponse Unmarshall(UnmarshallerContext context)
        {
			UpdateAliwsDictResponse updateAliwsDictResponse = new UpdateAliwsDictResponse();

			updateAliwsDictResponse.HttpResponse = context.HttpResponse;
			updateAliwsDictResponse.RequestId = context.StringValue("UpdateAliwsDict.RequestId");

			List<UpdateAliwsDictResponse.UpdateAliwsDict_DictList> updateAliwsDictResponse_result = new List<UpdateAliwsDictResponse.UpdateAliwsDict_DictList>();
			for (int i = 0; i < context.Length("UpdateAliwsDict.Result.Length"); i++) {
				UpdateAliwsDictResponse.UpdateAliwsDict_DictList dictList = new UpdateAliwsDictResponse.UpdateAliwsDict_DictList();
				dictList.Name = context.StringValue("UpdateAliwsDict.Result["+ i +"].Name");
				dictList.FileSize = context.LongValue("UpdateAliwsDict.Result["+ i +"].FileSize");
				dictList.Type = context.StringValue("UpdateAliwsDict.Result["+ i +"].Type");
				dictList.SourceType = context.StringValue("UpdateAliwsDict.Result["+ i +"].SourceType");

				UpdateAliwsDictResponse.UpdateAliwsDict_DictList.UpdateAliwsDict_OssObject ossObject = new UpdateAliwsDictResponse.UpdateAliwsDict_DictList.UpdateAliwsDict_OssObject();
				ossObject.BucketName = context.StringValue("UpdateAliwsDict.Result["+ i +"].OssObject.BucketName");
				ossObject.Key = context.StringValue("UpdateAliwsDict.Result["+ i +"].OssObject.Key");
				ossObject.Etag = context.StringValue("UpdateAliwsDict.Result["+ i +"].OssObject.Etag");
				dictList.OssObject = ossObject;

				updateAliwsDictResponse_result.Add(dictList);
			}
			updateAliwsDictResponse.Result = updateAliwsDictResponse_result;
        
			return updateAliwsDictResponse;
        }
    }
}
