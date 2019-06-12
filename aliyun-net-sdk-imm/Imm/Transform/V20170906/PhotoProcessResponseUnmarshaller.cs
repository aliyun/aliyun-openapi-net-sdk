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
using Aliyun.Acs.imm.Model.V20170906;

namespace Aliyun.Acs.imm.Transform.V20170906
{
    public class PhotoProcessResponseUnmarshaller
    {
        public static PhotoProcessResponse Unmarshall(UnmarshallerContext context)
        {
			PhotoProcessResponse photoProcessResponse = new PhotoProcessResponse();

			photoProcessResponse.HttpResponse = context.HttpResponse;
			photoProcessResponse.RequestId = context.StringValue("PhotoProcess.RequestId");
			photoProcessResponse.TaskId = context.StringValue("PhotoProcess.TaskId");
			photoProcessResponse.TgtLoc = context.StringValue("PhotoProcess.TgtLoc");
			photoProcessResponse.Status = context.StringValue("PhotoProcess.Status");
			photoProcessResponse.CreateTime = context.StringValue("PhotoProcess.CreateTime");
			photoProcessResponse.Percent = context.IntegerValue("PhotoProcess.Percent");
        
			return photoProcessResponse;
        }
    }
}
