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
using Aliyun.Acs.Emr.Model.V20160408;

namespace Aliyun.Acs.Emr.Transform.V20160408
{
    public class CreateNoteResponseUnmarshaller
    {
        public static CreateNoteResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateNoteResponse createNoteResponse = new CreateNoteResponse();

			createNoteResponse.HttpResponse = _ctx.HttpResponse;
			createNoteResponse.RequestId = _ctx.StringValue("CreateNote.RequestId");
			createNoteResponse.Id = _ctx.StringValue("CreateNote.Id");
			createNoteResponse.Paragraph = _ctx.StringValue("CreateNote.Paragraph");
        
			return createNoteResponse;
        }
    }
}
