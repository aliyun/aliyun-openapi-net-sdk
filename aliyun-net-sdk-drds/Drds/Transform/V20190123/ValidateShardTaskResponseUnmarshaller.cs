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
using Aliyun.Acs.Drds.Model.V20190123;

namespace Aliyun.Acs.Drds.Transform.V20190123
{
    public class ValidateShardTaskResponseUnmarshaller
    {
        public static ValidateShardTaskResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ValidateShardTaskResponse validateShardTaskResponse = new ValidateShardTaskResponse();

			validateShardTaskResponse.HttpResponse = _ctx.HttpResponse;
			validateShardTaskResponse.RequestId = _ctx.StringValue("ValidateShardTask.RequestId");
			validateShardTaskResponse.Success = _ctx.BooleanValue("ValidateShardTask.Success");

			List<ValidateShardTaskResponse.ValidateShardTask_ListItem> validateShardTaskResponse_list = new List<ValidateShardTaskResponse.ValidateShardTask_ListItem>();
			for (int i = 0; i < _ctx.Length("ValidateShardTask.List.Length"); i++) {
				ValidateShardTaskResponse.ValidateShardTask_ListItem listItem = new ValidateShardTaskResponse.ValidateShardTask_ListItem();
				listItem.Item = _ctx.StringValue("ValidateShardTask.List["+ i +"].Item");
				listItem.Result = _ctx.IntegerValue("ValidateShardTask.List["+ i +"].Result");

				validateShardTaskResponse_list.Add(listItem);
			}
			validateShardTaskResponse.List = validateShardTaskResponse_list;
        
			return validateShardTaskResponse;
        }
    }
}
