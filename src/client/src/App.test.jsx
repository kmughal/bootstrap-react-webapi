import React from "react"
import "@testing-library/dom"
import { render, waitFor } from "@testing-library/react"
import App from "./App"

describe("App tests", () => {
  test("Should display hello world", async () => {
    global.fetch = jest.fn(() =>
      Promise.resolve({
        ok: true,
        status: 200,
        json: () => [],
      })
    )

    const { getByText } = render(<App />)
    await waitFor(() => expect(global.fetch).toHaveBeenCalledTimes(1))
    expect(getByText("Hello World")).not.toBeNull()
    
  })
})
