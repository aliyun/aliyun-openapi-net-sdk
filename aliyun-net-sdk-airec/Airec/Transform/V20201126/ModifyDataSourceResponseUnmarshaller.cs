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
using Aliyun.Acs.Airec.Model.V20201126;

namespace Aliyun.Acs.Airec.Transform.V20201126
{
    public class ModifyDataSourceResponseUnmarshaller
    {
        public static ModifyDataSourceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ModifyDataSourceResponse modifyDataSourceResponse = new ModifyDataSourceResponse();

			modifyDataSourceResponse.HttpResponse = _ctx.HttpResponse;
			modifyDataSourceResponse.Code = _ctx.StringValue("ModifyDataSource.code");
			modifyDataSourceResponse.Message = _ctx.StringValue("ModifyDataSource.message");
			modifyDataSourceResponse.RequestId = _ctx.StringValue("ModifyDataSource.requestId");

			ModifyDataSourceResponse.ModifyDataSource_Result result = new ModifyDataSourceResponse.ModifyDataSource_Result();
			result.GmtCreate = _ctx.StringValue("ModifyDataSource.Result.gmtCreate");
			result.GmtModified = _ctx.StringValue("ModifyDataSource.Result.gmtModified");
			result.TableName = _ctx.StringValue("ModifyDataSource.Result.tableName");

			ModifyDataSourceResponse.ModifyDataSource_Result.ModifyDataSource_Meta meta = new ModifyDataSourceResponse.ModifyDataSource_Result.ModifyDataSource_Meta();
			meta.AccessKeyId = _ctx.StringValue("ModifyDataSource.Result.Meta.accessKeyId");
			meta.BucketName = _ctx.StringValue("ModifyDataSource.Result.Meta.bucketName");
			meta.Partition = _ctx.StringValue("ModifyDataSource.Result.Meta.partition");
			meta.Path = _ctx.StringValue("ModifyDataSource.Result.Meta.path");
			meta.ProjectName = _ctx.StringValue("ModifyDataSource.Result.Meta.projectName");
			meta.TableName = _ctx.StringValue("ModifyDataSource.Result.Meta.tableName");
			meta.Timestamp = _ctx.LongValue("ModifyDataSource.Result.Meta.timestamp");
			meta.Type = _ctx.StringValue("ModifyDataSource.Result.Meta.type");
			result.Meta = meta;
			modifyDataSourceResponse.Result = result;
        
			return modifyDataSourceResponse;
        }
    }
}
