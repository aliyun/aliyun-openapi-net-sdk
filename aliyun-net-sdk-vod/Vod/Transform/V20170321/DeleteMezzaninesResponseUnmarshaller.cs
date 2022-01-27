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
using Aliyun.Acs.vod.Model.V20170321;

namespace Aliyun.Acs.vod.Transform.V20170321
{
    public class DeleteMezzaninesResponseUnmarshaller
    {
        public static DeleteMezzaninesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DeleteMezzaninesResponse deleteMezzaninesResponse = new DeleteMezzaninesResponse();

			deleteMezzaninesResponse.HttpResponse = _ctx.HttpResponse;
			deleteMezzaninesResponse.RequestId = _ctx.StringValue("DeleteMezzanines.RequestId");

			List<string> deleteMezzaninesResponse_nonExistVideoIds = new List<string>();
			for (int i = 0; i < _ctx.Length("DeleteMezzanines.NonExistVideoIds.Length"); i++) {
				deleteMezzaninesResponse_nonExistVideoIds.Add(_ctx.StringValue("DeleteMezzanines.NonExistVideoIds["+ i +"]"));
			}
			deleteMezzaninesResponse.NonExistVideoIds = deleteMezzaninesResponse_nonExistVideoIds;

			List<string> deleteMezzaninesResponse_unRemoveableVideoIds = new List<string>();
			for (int i = 0; i < _ctx.Length("DeleteMezzanines.UnRemoveableVideoIds.Length"); i++) {
				deleteMezzaninesResponse_unRemoveableVideoIds.Add(_ctx.StringValue("DeleteMezzanines.UnRemoveableVideoIds["+ i +"]"));
			}
			deleteMezzaninesResponse.UnRemoveableVideoIds = deleteMezzaninesResponse_unRemoveableVideoIds;
        
			return deleteMezzaninesResponse;
        }
    }
}
