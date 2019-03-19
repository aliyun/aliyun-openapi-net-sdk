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
    public class GetBids4Uid4RootResponseUnmarshaller
    {
        public static GetBids4Uid4RootResponse Unmarshall(UnmarshallerContext context)
        {
			GetBids4Uid4RootResponse getBids4Uid4RootResponse = new GetBids4Uid4RootResponse();

			getBids4Uid4RootResponse.HttpResponse = context.HttpResponse;
			getBids4Uid4RootResponse.RequestId = context.StringValue("GetBids4Uid4Root.RequestId");
			getBids4Uid4RootResponse.Success = context.BooleanValue("GetBids4Uid4Root.Success");
			getBids4Uid4RootResponse.Message = context.StringValue("GetBids4Uid4Root.Message");
			getBids4Uid4RootResponse.Data = context.StringValue("GetBids4Uid4Root.Data");
			getBids4Uid4RootResponse.ErrorCode = context.IntegerValue("GetBids4Uid4Root.ErrorCode");
			getBids4Uid4RootResponse.ErrorMsg = context.StringValue("GetBids4Uid4Root.ErrorMsg");
        
			return getBids4Uid4RootResponse;
        }
    }
}
