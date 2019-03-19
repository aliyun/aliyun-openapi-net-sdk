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
using Aliyun.Acs.cloudwf.Model.V20170328;

namespace Aliyun.Acs.cloudwf.Transform.V20170328
{
    public class SaveApgroupConfigResponseUnmarshaller
    {
        public static SaveApgroupConfigResponse Unmarshall(UnmarshallerContext context)
        {
			SaveApgroupConfigResponse saveApgroupConfigResponse = new SaveApgroupConfigResponse();

			saveApgroupConfigResponse.HttpResponse = context.HttpResponse;
			saveApgroupConfigResponse.RequestId = context.StringValue("SaveApgroupConfig.RequestId");
			saveApgroupConfigResponse.Success = context.BooleanValue("SaveApgroupConfig.Success");
			saveApgroupConfigResponse.Message = context.StringValue("SaveApgroupConfig.Message");
			saveApgroupConfigResponse.Data = context.StringValue("SaveApgroupConfig.Data");
			saveApgroupConfigResponse.ErrorCode = context.IntegerValue("SaveApgroupConfig.ErrorCode");
			saveApgroupConfigResponse.ErrorMsg = context.StringValue("SaveApgroupConfig.ErrorMsg");
        
			return saveApgroupConfigResponse;
        }
    }
}
