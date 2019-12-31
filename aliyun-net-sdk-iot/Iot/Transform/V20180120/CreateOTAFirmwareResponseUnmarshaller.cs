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
using Aliyun.Acs.Iot.Model.V20180120;

namespace Aliyun.Acs.Iot.Transform.V20180120
{
    public class CreateOTAFirmwareResponseUnmarshaller
    {
        public static CreateOTAFirmwareResponse Unmarshall(UnmarshallerContext context)
        {
			CreateOTAFirmwareResponse createOTAFirmwareResponse = new CreateOTAFirmwareResponse();

			createOTAFirmwareResponse.HttpResponse = context.HttpResponse;
			createOTAFirmwareResponse.RequestId = context.StringValue("CreateOTAFirmware.RequestId");
			createOTAFirmwareResponse.Success = context.BooleanValue("CreateOTAFirmware.Success");
			createOTAFirmwareResponse.Code = context.StringValue("CreateOTAFirmware.Code");
			createOTAFirmwareResponse.ErrorMessage = context.StringValue("CreateOTAFirmware.ErrorMessage");

			CreateOTAFirmwareResponse.CreateOTAFirmware_Data data = new CreateOTAFirmwareResponse.CreateOTAFirmware_Data();
			data.FirmwareId = context.StringValue("CreateOTAFirmware.Data.FirmwareId");
			data.UtcCreate = context.StringValue("CreateOTAFirmware.Data.UtcCreate");
			createOTAFirmwareResponse.Data = data;
        
			return createOTAFirmwareResponse;
        }
    }
}
