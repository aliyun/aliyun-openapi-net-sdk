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
using System.Collections.Generic;

using Aliyun.Acs.Core;

namespace Aliyun.Acs.ocr.Model.V20191230
{
	public class RecognizeTableResponse : AcsResponse
	{

		private string requestId;

		private RecognizeTable_Data data;

		public string RequestId
		{
			get
			{
				return requestId;
			}
			set	
			{
				requestId = value;
			}
		}

		public RecognizeTable_Data Data
		{
			get
			{
				return data;
			}
			set	
			{
				data = value;
			}
		}

		public class RecognizeTable_Data
		{

			private string fileContent;

			private List<RecognizeTable_Table> tables;

			public string FileContent
			{
				get
				{
					return fileContent;
				}
				set	
				{
					fileContent = value;
				}
			}

			public List<RecognizeTable_Table> Tables
			{
				get
				{
					return tables;
				}
				set	
				{
					tables = value;
				}
			}

			public class RecognizeTable_Table
			{

				private List<RecognizeTable_TableRow> tableRows;

				private List<string> head;

				private List<string> tail;

				public List<RecognizeTable_TableRow> TableRows
				{
					get
					{
						return tableRows;
					}
					set	
					{
						tableRows = value;
					}
				}

				public List<string> Head
				{
					get
					{
						return head;
					}
					set	
					{
						head = value;
					}
				}

				public List<string> Tail
				{
					get
					{
						return tail;
					}
					set	
					{
						tail = value;
					}
				}

				public class RecognizeTable_TableRow
				{

					private List<RecognizeTable_TableColumn> tableColumns;

					public List<RecognizeTable_TableColumn> TableColumns
					{
						get
						{
							return tableColumns;
						}
						set	
						{
							tableColumns = value;
						}
					}

					public class RecognizeTable_TableColumn
					{

						private int? startColumn;

						private int? startRow;

						private int? endColumn;

						private int? endRow;

						private int? height;

						private int? width;

						private List<string> texts;

						public int? StartColumn
						{
							get
							{
								return startColumn;
							}
							set	
							{
								startColumn = value;
							}
						}

						public int? StartRow
						{
							get
							{
								return startRow;
							}
							set	
							{
								startRow = value;
							}
						}

						public int? EndColumn
						{
							get
							{
								return endColumn;
							}
							set	
							{
								endColumn = value;
							}
						}

						public int? EndRow
						{
							get
							{
								return endRow;
							}
							set	
							{
								endRow = value;
							}
						}

						public int? Height
						{
							get
							{
								return height;
							}
							set	
							{
								height = value;
							}
						}

						public int? Width
						{
							get
							{
								return width;
							}
							set	
							{
								width = value;
							}
						}

						public List<string> Texts
						{
							get
							{
								return texts;
							}
							set	
							{
								texts = value;
							}
						}
					}
				}
			}
		}
	}
}
