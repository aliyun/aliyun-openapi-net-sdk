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
using Aliyun.Acs.alikafka.Model.V20190916;

namespace Aliyun.Acs.alikafka.Transform.V20190916
{
    public class DeleteAclResponseUnmarshaller
    {
        public static DeleteAclResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DeleteAclResponse deleteAclResponse = new DeleteAclResponse();

			deleteAclResponse.HttpResponse = _ctx.HttpResponse;
			deleteAclResponse.Code = _ctx.IntegerValue("DeleteAcl.Code");
			deleteAclResponse.Message = _ctx.StringValue("DeleteAcl.Message");
			deleteAclResponse.RequestId = _ctx.StringValue("DeleteAcl.RequestId");
			deleteAclResponse.Success = _ctx.BooleanValue("DeleteAcl.Success");
        
			return deleteAclResponse;
        }
    }
}
