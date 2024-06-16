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
using Aliyun.Acs.dms_dg.Model.V20230914;

namespace Aliyun.Acs.dms_dg.Transform.V20230914
{
    public class ModifyDatabaseResponseUnmarshaller
    {
        public static ModifyDatabaseResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ModifyDatabaseResponse modifyDatabaseResponse = new ModifyDatabaseResponse();

			modifyDatabaseResponse.HttpResponse = _ctx.HttpResponse;
			modifyDatabaseResponse.Code = _ctx.StringValue("ModifyDatabase.Code");
			modifyDatabaseResponse.Data = _ctx.StringValue("ModifyDatabase.Data");
			modifyDatabaseResponse.ErrorMsg = _ctx.StringValue("ModifyDatabase.ErrorMsg");
			modifyDatabaseResponse.RequestId = _ctx.StringValue("ModifyDatabase.RequestId");
			modifyDatabaseResponse.Success = _ctx.BooleanValue("ModifyDatabase.Success");
        
			return modifyDatabaseResponse;
        }
    }
}
