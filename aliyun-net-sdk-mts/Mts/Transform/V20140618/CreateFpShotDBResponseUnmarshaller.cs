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
using Aliyun.Acs.Mts.Model.V20140618;

namespace Aliyun.Acs.Mts.Transform.V20140618
{
    public class CreateFpShotDBResponseUnmarshaller
    {
        public static CreateFpShotDBResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateFpShotDBResponse createFpShotDBResponse = new CreateFpShotDBResponse();

			createFpShotDBResponse.HttpResponse = _ctx.HttpResponse;
			createFpShotDBResponse.RequestId = _ctx.StringValue("CreateFpShotDB.RequestId");

			CreateFpShotDBResponse.CreateFpShotDB_FpShotDB fpShotDB = new CreateFpShotDBResponse.CreateFpShotDB_FpShotDB();
			fpShotDB.Description = _ctx.StringValue("CreateFpShotDB.FpShotDB.Description");
			fpShotDB.State = _ctx.StringValue("CreateFpShotDB.FpShotDB.State");
			fpShotDB.Name = _ctx.StringValue("CreateFpShotDB.FpShotDB.Name");
			fpShotDB.FpDBId = _ctx.StringValue("CreateFpShotDB.FpShotDB.FpDBId");
			fpShotDB.ModelId = _ctx.IntegerValue("CreateFpShotDB.FpShotDB.ModelId");
			fpShotDB.Config = _ctx.StringValue("CreateFpShotDB.FpShotDB.Config");
			fpShotDB.InstanceId = _ctx.StringValue("CreateFpShotDB.FpShotDB.InstanceId");
			createFpShotDBResponse.FpShotDB = fpShotDB;
        
			return createFpShotDBResponse;
        }
    }
}
