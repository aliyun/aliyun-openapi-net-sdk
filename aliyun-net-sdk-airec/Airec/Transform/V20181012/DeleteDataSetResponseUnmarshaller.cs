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
using Aliyun.Acs.Airec.Model.V20181012;

namespace Aliyun.Acs.Airec.Transform.V20181012
{
    public class DeleteDataSetResponseUnmarshaller
    {
        public static DeleteDataSetResponse Unmarshall(UnmarshallerContext context)
        {
			DeleteDataSetResponse deleteDataSetResponse = new DeleteDataSetResponse();

			deleteDataSetResponse.HttpResponse = context.HttpResponse;
			deleteDataSetResponse.RequestId = context.StringValue("DeleteDataSet.RequestId");
			deleteDataSetResponse.Code = context.StringValue("DeleteDataSet.Code");
			deleteDataSetResponse.Message = context.StringValue("DeleteDataSet.Message");

			DeleteDataSetResponse.DeleteDataSet_Result result = new DeleteDataSetResponse.DeleteDataSet_Result();
			result.InstanceId = context.StringValue("DeleteDataSet.Result.InstanceId");
			result.VersionId = context.StringValue("DeleteDataSet.Result.VersionId");
			result.State = context.StringValue("DeleteDataSet.Result.State");
			result.GmtCreate = context.LongValue("DeleteDataSet.Result.GmtCreate");
			result.GmtModified = context.LongValue("DeleteDataSet.Result.GmtModified");
			deleteDataSetResponse.Result = result;
        
			return deleteDataSetResponse;
        }
    }
}
