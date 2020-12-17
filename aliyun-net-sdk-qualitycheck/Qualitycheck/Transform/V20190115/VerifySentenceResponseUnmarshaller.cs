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
using Aliyun.Acs.Qualitycheck.Model.V20190115;

namespace Aliyun.Acs.Qualitycheck.Transform.V20190115
{
    public class VerifySentenceResponseUnmarshaller
    {
        public static VerifySentenceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			VerifySentenceResponse verifySentenceResponse = new VerifySentenceResponse();

			verifySentenceResponse.HttpResponse = _ctx.HttpResponse;
			verifySentenceResponse.RequestId = _ctx.StringValue("VerifySentence.RequestId");
			verifySentenceResponse.Success = _ctx.BooleanValue("VerifySentence.Success");
			verifySentenceResponse.Code = _ctx.StringValue("VerifySentence.Code");
			verifySentenceResponse.Message = _ctx.StringValue("VerifySentence.Message");
			verifySentenceResponse.SourceRole = _ctx.IntegerValue("VerifySentence.SourceRole");
			verifySentenceResponse.TargetRole = _ctx.IntegerValue("VerifySentence.TargetRole");
			verifySentenceResponse.IncorrectWords = _ctx.IntegerValue("VerifySentence.IncorrectWords");

			List<VerifySentenceResponse.VerifySentence_Delta> verifySentenceResponse_data = new List<VerifySentenceResponse.VerifySentence_Delta>();
			for (int i = 0; i < _ctx.Length("VerifySentence.Data.Length"); i++) {
				VerifySentenceResponse.VerifySentence_Delta delta = new VerifySentenceResponse.VerifySentence_Delta();
				delta.Type = _ctx.StringValue("VerifySentence.Data["+ i +"].Type");

				VerifySentenceResponse.VerifySentence_Delta.VerifySentence_Source source = new VerifySentenceResponse.VerifySentence_Delta.VerifySentence_Source();
				source.Position = _ctx.IntegerValue("VerifySentence.Data["+ i +"].Source.Position");

				List<string> source_line = new List<string>();
				for (int j = 0; j < _ctx.Length("VerifySentence.Data["+ i +"].Source.Line.Length"); j++) {
					source_line.Add(_ctx.StringValue("VerifySentence.Data["+ i +"].Source.Line["+ j +"]"));
				}
				source.Line = source_line;
				delta.Source = source;

				VerifySentenceResponse.VerifySentence_Delta.VerifySentence_Target target = new VerifySentenceResponse.VerifySentence_Delta.VerifySentence_Target();
				target.Position = _ctx.IntegerValue("VerifySentence.Data["+ i +"].Target.Position");

				List<string> target_line1 = new List<string>();
				for (int j = 0; j < _ctx.Length("VerifySentence.Data["+ i +"].Target.Line.Length"); j++) {
					target_line1.Add(_ctx.StringValue("VerifySentence.Data["+ i +"].Target.Line["+ j +"]"));
				}
				target.Line1 = target_line1;
				delta.Target = target;

				verifySentenceResponse_data.Add(delta);
			}
			verifySentenceResponse.Data = verifySentenceResponse_data;
        
			return verifySentenceResponse;
        }
    }
}
